using Microsoft.Scripting.Utils;
using MissionPlanner.Comms;
using MissionPlanner.Controls;
using MissionPlanner.GCSViews.ConfigurationView;
using MissionPlanner.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;

using System.Windows.Forms;
using Xamarin.Essentials;
using static MAVLink;
using ZedGraph;
using System.Drawing;

namespace MissionPlanner
{
    public partial class Dual_Serial_Ports : Form
    {

        private MAVLinkInterface comPort1 = new MAVLinkInterface();

        System.Threading.Thread _thread;
       private bool threadrun = false;
       private TcpListener listener;

        static Dual_Serial_Ports Instance;

        private ICommsSerial outputTCP; 
        DateTime com1_last_HB = DateTime.Now;
        DateTime com1_last_TX = DateTime.Now;
        DateTime com1_last_FTP = DateTime.Now;
        DateTime com1_last_ACK = DateTime.Now;
        DateTime com2_last_HB = DateTime.Now;
        int packetRXCount1, packetRXCount2;  
        int packetSentCount1, packetSentCount2;

        public RollingPointPairList com1_qos = new RollingPointPairList(600);

        public Dual_Serial_Ports()
        {
            InitializeComponent();
            Instance = this;

            CMB_serialport.Items.AddRange(SerialPort.GetPortNames());
            CMB_serialport.Items.Add("TCP Host - 14550");
            CMB_serialport.Items.Add("TCP Client");
            CMB_serialport.Items.Add("UDP Host - 14550");
            CMB_serialport.Items.Add("UDP Client");


            zed_com1.GraphPane.Title.Text = "COM1 QOS";
            zed_com1.GraphPane.AddCurve("QOS", com1_qos, Color.Yellow,SymbolType.None);
            zed_com1.GraphPane.Legend.IsVisible = false;
            zed_com1.GraphPane.XAxis.Type = AxisType.Date;
            zed_com1.GraphPane.YAxis.Scale.Min = 0;
            zed_com1.GraphPane.YAxis.Scale.Max = 120;
            zed_com1.GraphPane.YAxis.Title.IsVisible = false;
            zed_com1.GraphPane.XAxis.Title.IsVisible = false;

        }

        private void updateCOM1Plot(double qos_val)
        {
            if (qos_val == null) return;
            com1_qos.Add((double)new XDate(DateTime.Now), (double)qos_val);
            zed_com1.AxisChange();
            zed_com1.Invalidate();
        }

        private void start_thread()
        {
            if (threadrun)
            {
                statusLine("Thread already running?");
                return;
            }
            threadrun = true;
            _thread = new System.Threading.Thread(new System.Threading.ThreadStart(mainloop))
            {
                IsBackground = true,
                Name = "Dual Comm Port Thread"
            };
            _thread.Start();

        }

        private void packetReceivedHandler1(object sender, MAVLink.MAVLinkMessage mavLinkMessage)
        {
            packetReceivedHandler(sender, mavLinkMessage, 1); 
        }

        private void packetReceivedHandler2(object sender, MAVLink.MAVLinkMessage mavLinkMessage)
        {
            packetReceivedHandler(sender, mavLinkMessage, 2);
        }

        private void statusLine(string str)
        {
            this.Invoke((MethodInvoker)delegate
            {
                rt_log.Text += DateTime.Now.ToShortDateString() + " " + str + "\n" + rt_log.Text;
            });
        }

        static List<ushort> cmdsIgnore = new List<ushort> {
            (ushort) MAVLink.MAVLINK_MSG_ID.AUTOPILOT_VERSION_REQUEST,
            (ushort) MAVLink.MAVLINK_MSG_ID.REQUEST_DATA_STREAM,
            512,
            520

        };

        private void packetReceivedHandler(object sender, MAVLink.MAVLinkMessage mavLinkMessage, int comNum)
        {
            packetRXCount1++; 
            if (mavLinkMessage.msgid == (uint)MAVLink.MAVLINK_MSG_ID.HEARTBEAT) com1_last_HB = DateTime.Now.AddMilliseconds(200);
            if (mavLinkMessage.msgid == (uint)MAVLink.MAVLINK_MSG_ID.FILE_TRANSFER_PROTOCOL) com1_last_FTP = DateTime.Now.AddMilliseconds(200);
            if (mavLinkMessage.msgid == (uint)MAVLink.MAVLINK_MSG_ID.COMMAND_ACK &&
                !cmdsIgnore.Contains(((MAVLink.mavlink_command_ack_t)mavLinkMessage.data).command))
            {
                com1_last_ACK = DateTime.Now.AddMilliseconds(200);
                statusLine("COM1 ACK RECEIVED: " + ((MAVLink.mavlink_command_ack_t)mavLinkMessage.data).command); 
            }

            if (outputTCP != null && outputTCP.IsOpen)
                outputTCP.Write(mavLinkMessage.buffer,0,mavLinkMessage.buffer.Length);
        }

        private void packetSentHandler1(object sender, MAVLink.MAVLinkMessage mavLinkMessage)
        {
            //Console.WriteLine("{DUAL} Sending: " + mavLinkMessage.ToString());
            //packetSentCount1++;
            //com1_last_TX = DateTime.Now.AddMilliseconds(200);
        }
        private void packetSentHandler2(object sender, MAVLink.MAVLinkMessage mavLinkMessage)
        {
            packetSentCount2++;
        }


        private void BUT_connect_Click(object sender, EventArgs e)
        {

            lbl_com1_status.Text = "Connecting to " + CMB_serialport.Text + "...";
            switch (CMB_serialport.Text)
            {
                case "TCP":
                    this.comPort1.BaseStream = new TcpSerial();
                    break;
                case "UDP":
                    this.comPort1.BaseStream = new UdpSerial();
                    break;
                case "WS":
                    this.comPort1.BaseStream = new WebSocket();
                    break;
                case "UDPCl":
                    this.comPort1.BaseStream = new UdpSerialConnect();
                    break;
                default:
                    this.comPort1.BaseStream = new SerialPort();
                    break;
            }

            try
            {
                this.comPort1.BaseStream.PortName = CMB_serialport.Text;
                if (CMB_baudrate.Text != "" && CMB_baudrate.Text != "0" && CMB_baudrate.Text.IsNumber())
                    comPort1.BaseStream.BaudRate = int.Parse(CMB_baudrate.Text);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp);
            }

            this.comPort1.OnPacketReceived += this.packetReceivedHandler1;
            this.comPort1.OnPacketSent += this.packetSentHandler1;


            // do the connect
            this.comPort1.Open(false, false, false);


            if (!this.comPort1.BaseStream.IsOpen)
            {
                statusLine("{DUAL} comport is closed. existing connect");
                try
                {
                    //_connectionControl.IsConnected(false);
                    //UpdateConnectIcon();
                    this.comPort1.Close();
                }
                catch
                {
                }

                return;
            }

            this.comPort1.giveComport = false;
            lbl_com1_status.Text = "Com Port OPened..."; 
            this.comPort1.getHeartBeat();
            lbl_com1_status.Text = "Got Heartbeat.... ";
            statusLine("{DUAL} Comm Port 1 Open");


            lbl_TCP_Status.Text = "Starting TCP Connection...";

            if (this.outputTCP == null || !this.outputTCP.IsOpen)
            {
                this.outputTCP = new TcpSerial(); //new UdpSerial() { ConfigRef = "SerialOutputPassUDP", Port = "14550" };//  new UdpSerialConnect() { ConfigRef = "SerialOutputPassUDPCL" };
                this.listener = new TcpListener(System.Net.IPAddress.Any, 14558);
                this.listener.Start(0);
                this.listener.BeginAcceptTcpClient(new AsyncCallback(DoAcceptTcpClientCallback), this.listener);
                statusLine("{DUAL} TCP Listener Open");

                lbl_TCP_Status.Text = "TCP Service Started at port " + 14558;
            } else
            {
                statusLine("TCP Already running?");
            }
            this.start_thread();
            statusLine("{DUAL} Main background thread started");



        }

        void DoAcceptTcpClientCallback(IAsyncResult ar)
        {
            // Get the listener that handles the client request.
            TcpListener listener = (TcpListener)ar.AsyncState;

            // End the operation and display the received data on  
            // the console.
            TcpClient client = listener.EndAcceptTcpClient(ar);

            ((TcpSerial)outputTCP).client = client;

            listener.BeginAcceptTcpClient(new AsyncCallback(DoAcceptTcpClientCallback), listener);

            statusLine("{DUAL} TCP Client Connected " + listener.LocalEndpoint.ToString());

            this.Invoke((MethodInvoker)delegate
            {
                this.lbl_TCP_Status.Text = "Connected to: " + listener.LocalEndpoint.ToString();
            });
        }

        private void mainloop()
        {
            //Console.WriteLine("{DUAL}Trying to Connect....");
            //Thread.Sleep(5000);
            //this.comPort1.BaseStream = new SerialPort();
            //this.comPort1.BaseStream.PortName = "COM40";
            //this.comPort1.BaseStream.BaudRate = 19200;

            //this.comPort1.OnPacketReceived += this.packetReceivedHandler;
            ////comPort1.OnPacketSent += packetSentHandler;

            //// do the connect
            //this.comPort1.Open(false, false, false);

            //this.comPort1.giveComport = false;
            try
            {
                DateTime lastPrint = DateTime.Now;
                MavlinkParse mlParser = new MavlinkParse();

                this.threadrun = true;
                while (this.threadrun)
                {
                    Thread.Sleep(1);

                    //this.comPort1.getHeartBeat();
                    DateTime startread = DateTime.Now;

                    // must be open, we have bytes, we are not yielding the port,
                    // the thread is meant to be running and we only spend 1 seconds max in this read loop
                    while (this.comPort1.BaseStream.IsOpen && this.comPort1.BaseStream.BytesToRead > 10 &&
                           this.comPort1.giveComport == false && startread.AddSeconds(1) > DateTime.Now)
                    {
                        try
                        {
                            this.comPort1.readPacket();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("{DUAL} Read Packet Error: " + ex);
                        }
                    }
                    this.comPort1.MAV.cs.UpdateCurrentSettings(null, false, this.comPort1, this.comPort1.MAV);

                    // TODO: need to add a line here to make this part only run every few seconds. 
                    if (lastPrint.Second != DateTime.Now.Second) { 
                        if (this.comPort1 != null && this.comPort1.BaseStream != null && this.comPort1.BaseStream.IsOpen)
                        {

                            Console.WriteLine("{DUAL} COM 1 Open: " + this.comPort1.BaseStream.IsOpen + " " + this.comPort1.BaseStream.ToString() + " LQ: " + this.comPort1.MAV.cs.linkqualitygcs);
                            this.Invoke((MethodInvoker)delegate
                            {
                                String s = ""; 
                                s =  string.Format("{0,-20}{1}\n", "Quality:",        comPort1.MAV.cs.linkqualitygcs);
                                s += string.Format("{0,-20}{1}\n", "Packets RX: ",    comPort1.MAV.packetsnotlost);
                                s += string.Format("{0,-20}{1}\n", "Packets Lost:",   comPort1.MAV.packetslost);
                                s += string.Format("{0,-20}{1}\n", "RX / Sec: ",      packetRXCount1);
                                s += string.Format("{0,-20}{1}\n", "TX / Sec: ",      packetSentCount1);
                                lbl_com1_status.Text = s;
                                packetRXCount1 = 0;
                                packetSentCount1 = 0;

                                updateCOM1Plot(comPort1.MAV.cs.linkqualitygcs);
                            });
                        }
                        else
                        {
                            statusLine("{DUAL} COMPORT1 BaseStream not open.");
                        }
                        lastPrint = DateTime.Now;
                    }   
                    


                    while (outputTCP.BytesToRead > 0)
                    {
                        MAVLinkMessage msg = mlParser.ReadPacket(outputTCP.BaseStream);

                        if (msg != null)
                        {
                            this.comPort1.BaseStream.Write(msg.buffer, 0, msg.buffer.Length);

                            Console.WriteLine("{DUAL} Forwarding Message: " + msg.ToString());

                            packetSentCount1++;
                            com1_last_TX = DateTime.Now.AddMilliseconds(200);
                        }
                        //var len = outputTCP.BytesToRead;
                        
                        //byte[] buf = new byte[len];

                        //len = outputTCP.Read(buf, 0, len);

                        //this.comPort1.BaseStream.Write(buf, 0, len); ;
                        
                    }

                    // Display Housekeeping
                    this.Invoke((MethodInvoker)delegate
                    {
                        this.led_com1_rx.On = (DateTime.Now < this.com1_last_HB);
                        this.led_com1_tx.On = (DateTime.Now < this.com1_last_TX);
                        this.led_com1_ftp.On = (DateTime.Now < this.com1_last_FTP);
                        this.led_com1_ack.On = (DateTime.Now < this.com1_last_ACK);
                        this.vpb_com1.Value = this.comPort1.MAV.cs.linkqualitygcs;
                        if (this.vpb_com1.Value < 25) this.vpb_com1.maxline = 25; 
                    });

                }
            } catch (Exception ex)
            {
                Console.WriteLine("Error in Dual Loop: " + ex);
            } finally
            {
                this.threadrun = false;
            }
            
        }
        
    }
}
