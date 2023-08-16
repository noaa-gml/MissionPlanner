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

namespace MissionPlanner
{
    public partial class Dual_Serial_Ports : UserControl
    {

        private MAVLinkInterface comPort1 = new MAVLinkInterface();

        System.Threading.Thread _thread;
       private bool threadrun = false;
       private TcpListener listener;

        static Dual_Serial_Ports Instance;

        private ICommsSerial outputUDP; 

        public Dual_Serial_Ports()
        {
            InitializeComponent();
            Instance = this;

            CMB_serialport.Items.AddRange(SerialPort.GetPortNames());
            CMB_serialport.Items.Add("TCP Host - 14550");
            CMB_serialport.Items.Add("TCP Client");
            CMB_serialport.Items.Add("UDP Host - 14550");
            CMB_serialport.Items.Add("UDP Client");


        }

        private void start_thread()
        {
            threadrun = true;
            _thread = new System.Threading.Thread(new System.Threading.ThreadStart(mainloop))
            {
                IsBackground = true,
                Name = "Dual Comm Port Thread"
            };
            _thread.Start();

        }

        private void packetReceivedHandler(object sender, MAVLink.MAVLinkMessage mavLinkMessage)
        {
            //Console.WriteLine("{DUAL} Handling: " + mavLinkMessage.ToString());
            if (outputUDP != null && outputUDP.IsOpen)
                outputUDP.Write(mavLinkMessage.buffer,0,mavLinkMessage.buffer.Length);
        }

        private void packetSentHandler(object sender, MAVLink.MAVLinkMessage mavLinkMessage)
        {

        }

        private void BUT_connect_Click(object sender, EventArgs e)
        {
            

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

            this.comPort1.OnPacketReceived += this.packetReceivedHandler;
            //comPort1.OnPacketSent += packetSentHandler;

            // do the connect
            this.comPort1.Open(false, false, false);


            if (!this.comPort1.BaseStream.IsOpen)
            {
                Console.WriteLine("{DUAL} comport is closed. existing connect");
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

            this.comPort1.getHeartBeat();

            Console.WriteLine("{DUAL} Comm Port 1 Open");

            this.outputUDP = new TcpSerial(); //new UdpSerial() { ConfigRef = "SerialOutputPassUDP", Port = "14550" };//  new UdpSerialConnect() { ConfigRef = "SerialOutputPassUDPCL" };
            this.listener = new TcpListener(System.Net.IPAddress.Any, 14558);
            this.listener.Start(0);
            this.listener.BeginAcceptTcpClient(new AsyncCallback(DoAcceptTcpClientCallback), this.listener);
            Console.WriteLine("{DUAL} TCP Listener Open");



            this.start_thread();
            Console.WriteLine("{DUAL} Main background thread started");



        }

        void DoAcceptTcpClientCallback(IAsyncResult ar)
        {
            // Get the listener that handles the client request.
            TcpListener listener = (TcpListener)ar.AsyncState;

            // End the operation and display the received data on  
            // the console.
            TcpClient client = listener.EndAcceptTcpClient(ar);

            ((TcpSerial)outputUDP).client = client;

            listener.BeginAcceptTcpClient(new AsyncCallback(DoAcceptTcpClientCallback), listener);

            Console.WriteLine("{DUAL} TCP Client Connected " + listener.LocalEndpoint.ToString());
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


                this.threadrun = true;
                while (this.threadrun)
                {
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

                    // need to add a line here to make this part only run every few seconds. 

                    if (this.comPort1 != null && this.comPort1.BaseStream != null && this.comPort1.BaseStream.IsOpen)
                    {

                        Console.WriteLine("{DUAL} COM 1 Open: " + this.comPort1.BaseStream.IsOpen + " " + this.comPort1.BaseStream.ToString() + " LQ: " + this.comPort1.MAV.cs.linkqualitygcs);
                    }
                    else
                    {
                        Console.WriteLine("{DUAL} COMPORT1 BaseStream not open.");
                    }
                    //Thread.Sleep(1);


                    while (outputUDP.BytesToRead > 0)
                    {
                        Console.WriteLine("{DUAL} Have " + outputUDP.BytesToRead + " Bytes to write.");
                        var len = outputUDP.BytesToRead;

                        byte[] buf = new byte[len];

                        len = outputUDP.Read(buf, 0, len);

                        this.comPort1.BaseStream.Write(buf, 0, len); ;
                    }
                }
            } catch
            {
                Console.WriteLine("Error in Dual Loop.");
            }
        }

    }
}
