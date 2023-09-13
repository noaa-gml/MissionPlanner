using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using MissionPlanner.Comms;
using static MAVLink;
using ZedGraph; 

namespace DualTelem
{

    

    public partial class DualTelem_Main : Form
    {
        public class MovingAverage
        {
            private Queue<Double> samples = new Queue<Double>();
            private int windowSize = 20;
            private Double sampleAccumulator;
            public Double Average { get; private set; }

            public MovingAverage()
            {
                // iniitalized the moving average to 100's. 
                this.ComputeAverage(1.0);
            }

            public void ComputeAverage(Double newSample)
            {
                sampleAccumulator += newSample;
                samples.Enqueue(newSample);

                if (samples.Count > windowSize)
                {
                    sampleAccumulator -= samples.Dequeue();
                }

                Average = sampleAccumulator / samples.Count;
            }
        }


        System.Threading.Thread _thread;
        private bool threadrun = false;

        private ICommsSerial comPort1 = null;
        private ICommsSerial comPort2 = null;

        private ICommsSerial outputTCP = null;
        private TcpListener listener;
        private bool listenerStarted;

        DateTime com1_last_HB = DateTime.Now;
        DateTime com1_last_TX = DateTime.Now;
        DateTime com1_last_FTP = DateTime.Now;
        DateTime com1_last_ACK = DateTime.Now;

        DateTime com2_last_HB = DateTime.Now;
        DateTime com2_last_TX = DateTime.Now;
        DateTime com2_last_FTP = DateTime.Now;
        DateTime com2_last_ACK = DateTime.Now;


        bool got_hb1, got_tx1, got_ftp1, got_ack1;
        bool got_hb2, got_tx2, got_ftp2, got_ack2;

        int[] packetRXCount = new int[2]; 
        int[] packetSentCount = new int[2];
        int[] packetLostCount = new int[2];
        int[] bytesRXCount = new int[2];
        int[] bytesRXBad = new int[2];
        int[] bytesTXCount = new int[2];
        float[] linkQOS = new float[2];

        byte[][] lastSeq = new byte[2][];
        bool[] gotFirstHB = { false, false }; 


        MovingAverage[] lqAvg = new MovingAverage[2];
        public RollingPointPairList com1_qos = new RollingPointPairList(600);
        public RollingPointPairList com2_qos = new RollingPointPairList(600);

        public DualTelem_Main()
        {
            InitializeComponent();
            timer1.Start();
            timer2.Start();
            start_thread();

            lastSeq[0] = new byte[255];
            lastSeq[1] = new byte[255];

            lqAvg[0] = new MovingAverage();
            lqAvg[1] = new MovingAverage();

            zed_qos_plot.GraphPane.Title.Text = "QOS - COM1 (Blue) COM2 (green)";
            zed_qos_plot.GraphPane.AddCurve("QOS", com1_qos, Color.Blue, SymbolType.None);
            zed_qos_plot.GraphPane.AddCurve("QOS", com2_qos, Color.Green, SymbolType.None);
            zed_qos_plot.GraphPane.Legend.IsVisible = false;
            zed_qos_plot.GraphPane.XAxis.Type = AxisType.Date;
            zed_qos_plot.GraphPane.YAxis.Scale.Min = 0;
            zed_qos_plot.GraphPane.YAxis.Scale.Max = 120;
            zed_qos_plot.GraphPane.YAxis.Title.IsVisible = false;
            zed_qos_plot.GraphPane.XAxis.Title.IsVisible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (got_hb1) { com1_last_HB = DateTime.Now.AddMilliseconds(200); got_hb1 = false; }
            if (got_tx1) { com1_last_TX = DateTime.Now.AddMilliseconds(200); got_tx1 = false; }
            if (got_ftp1) { com1_last_FTP = DateTime.Now.AddMilliseconds(200); got_ftp1 = false; }
            if (got_ack1) { com1_last_ACK = DateTime.Now.AddMilliseconds(200); got_ack1 = false; }

            led_hb1.On = (DateTime.Now < com1_last_HB);
            led_tx1.On = (DateTime.Now < com1_last_TX);
            led_ftp1.On = (DateTime.Now < com1_last_FTP);
            led_ack1.On = (DateTime.Now < com1_last_ACK);

            if (got_hb2) { com2_last_HB = DateTime.Now.AddMilliseconds(200); got_hb2 = false; }
            if (got_tx2) { com2_last_TX = DateTime.Now.AddMilliseconds(200); got_tx2 = false; }
            if (got_ftp2) { com2_last_FTP = DateTime.Now.AddMilliseconds(200); got_ftp2 = false; }
            if (got_ack2) { com2_last_ACK = DateTime.Now.AddMilliseconds(200); got_ack2 = false; }

            led_hb2.On = (DateTime.Now < com2_last_HB);
            led_tx2.On = (DateTime.Now < com2_last_TX);
            led_ftp2.On = (DateTime.Now < com2_last_FTP);
            led_ack2.On = (DateTime.Now < com2_last_ACK);


        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            // we add to the QOS moving average every second 
            if (gotFirstHB[0])
            {
                if (packetRXCount[0] + packetLostCount[0] == 0)
                {
                    lqAvg[0].ComputeAverage(0.0);
                }
                else
                {
                    lqAvg[0].ComputeAverage(1.0 * packetRXCount[0] / (packetRXCount[0] + packetLostCount[0]));
                }
                linkQOS[0] = (float)lqAvg[0].Average * 100.0f;
            }

            String s = (comPort1 != null && comPort1.IsOpen) ? (comPort1.PortName + "\n"):"Not Open";
            s = string.Format("{0,-20}{1}\n", "Quality: ", linkQOS[0]);
            s += string.Format("{0,-20}{1}\n", "Packets RX: ", packetRXCount[0]);
            s += string.Format("{0,-20}{1}\n", "Packets Lost:", packetLostCount[0]);
            s += string.Format("{0,-20}{1}\n", "Packets Sent: ", packetSentCount[0]);
            s += string.Format("{0,-20}{1} bps\n", "Receive Rate: ", bytesRXCount[0]*10);
            s += string.Format("{0,-20}{1} bps\n", "Transmit Rate: ", bytesTXCount[0] * 10);
            lbl_com1_status.Text = s;
            packetRXCount[0] = 0;
            packetLostCount[0] = 0;
            packetSentCount[0] = 0;
            bytesRXCount[0] = 0;
            bytesTXCount[0] = 0;

            if (gotFirstHB[1])
            {
                if (packetRXCount[1] + packetLostCount[1] == 0)
                {
                    lqAvg[1].ComputeAverage(0.0);
                }
                else
                {
                    lqAvg[1].ComputeAverage(1.0 * packetRXCount[1] / (packetRXCount[1] + packetLostCount[1]));
                }
                linkQOS[1] = (float)lqAvg[1].Average * 100.0f;
            }
            s = (comPort2 != null && comPort2.IsOpen) ? (comPort2.PortName + "\n") : "Not Open";
            s = string.Format("{0,-20}{1}\n", "Quality: ", linkQOS[1]);
            s += string.Format("{0,-20}{1}\n", "Packets RX: ", packetRXCount[1]);
            s += string.Format("{0,-20}{1}\n", "Packets Lost:", packetLostCount[1]);
            s += string.Format("{0,-20}{1}\n", "Packets Sent: ", packetSentCount[1]);
            s += string.Format("{0,-20}{1} bps\n", "Receive Rate: ", bytesRXCount[1]*10);
            s += string.Format("{0,-20}{1} bps\n", "Transmit Rate: ", bytesTXCount[1] * 10);
            lbl_com2_status.Text = s;
            packetRXCount[1] = 0;
            packetLostCount[1] = 0;
            packetSentCount[1] = 0;
            bytesRXCount[1] = 0;
            bytesTXCount[1] = 0;

            // Update Slow Screen Elements
            bar_com1.Value = (int) linkQOS[0];
            bar_com2.Value = (int)linkQOS[1];

            updateCOMPlot(linkQOS[0], linkQOS[1]);
        }

        private void updateCOMPlot(double qos_val1, double qos_val2)
        {
            if (qos_val1 != null) com1_qos.Add((double)new XDate(DateTime.Now), (double)qos_val1);
            else com1_qos.Add((double)new XDate(DateTime.Now), (double)0);

            if (qos_val2 != null) com2_qos.Add((double)new XDate(DateTime.Now), (double)qos_val2);
            else com2_qos.Add((double)new XDate(DateTime.Now), (double)0);

            zed_qos_plot.AxisChange();
            zed_qos_plot.Invalidate();
        }


        private void start_thread()
        {
            if (threadrun)
            {
                Console.WriteLine("Thread already running?");
                return;
            }
            threadrun = true;
            _thread = new System.Threading.Thread(new System.Threading.ThreadStart(mainLoop))
            {
                IsBackground = true,
                Name = "Dual Comm Port Thread"
            };
            _thread.Start();
            Console.WriteLine("Main background thread started");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                comPort1 = new SerialPort();
                comPort1.PortName = "COM11";
                comPort1.BaudRate = 115200;


                openSerial(ref comPort1);

                got_hb1 = true;
                got_tx1 = true;
                got_ack1 = true;
                got_ftp1 = true;

            } catch (Exception ex) { 
                Console.WriteLine("Error opening Com Port: " + ex);
            }


        }


        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                comPort2 = new SerialPort();
                comPort2.PortName = "COM31";
                comPort2.BaudRate = 19200;

                openSerial(ref comPort2);

                got_hb2 = true;
                got_tx2 = true;
                got_ack2 = true;
                got_ftp2 = true;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error opening Com Port: " + ex);
            }
        }
        private void openSerial(ref ICommsSerial comPort)
        {
            try
            {
                comPort.ReadBufferSize = 1024 * 16;
                comPort.Open();
                comPort.DiscardInBuffer();


                Console.WriteLine("Opened " + comPort.PortName + " In Buffer: " + comPort.ReadBufferSize + " Out Buffer: " + comPort.WriteBufferSize); 
            } catch (Exception ex)
            {
                Console.WriteLine("Error Opening Serial: " + ex); 
            }
            openOutput();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            openOutput();
        }

        private void openOutput()
        {
            try
            {
                if (outputTCP == null)
                {
                    outputTCP = new TcpSerial(); //new UdpSerial() { ConfigRef = "SerialOutputPassUDP", Port = "14550" };//  new UdpSerialConnect() { ConfigRef = "SerialOutputPassUDPCL" };
                }

                if (!outputTCP.IsOpen && !listenerStarted)
                {
                    listener = new TcpListener(System.Net.IPAddress.Any, 14558);
                    listener.Start(0);
                    listener.BeginAcceptTcpClient(new AsyncCallback(DoAcceptTcpClientCallback), listener);
                    listenerStarted = true;
                    Console.WriteLine("TCP Listener Open");
                }
                else
                {
                    Console.WriteLine("TCP Listener Open");
                }
                Console.WriteLine("Opened " + outputTCP.PortName);
            } catch (Exception ex)
            {
                Console.WriteLine("Error Opening Output Connection: " + ex);
            }
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

            Console.WriteLine("TCP Client Connected " + listener.LocalEndpoint.ToString());


        }


        private void updateComStat(int comNum, byte compid, byte seq) 
        {
            int idx = comNum - 1;
            if (idx < 0 || idx > 1) return;

            // this gets called once a packet, so increment
            packetRXCount[idx]++;


            // determine lost packets
            int expectedSeq = ((lastSeq[idx][compid] + 1) % 0x100);
            if (seq  != expectedSeq)
            {
                if (seq > lastSeq[idx][compid])
                    packetLostCount[idx] += seq - expectedSeq;
                else
                    packetLostCount[idx] += 255 - expectedSeq + seq;
            }

            lastSeq[idx][compid] = (byte) seq; 
        }

        private void processComChunk(int comNum, ref ICommsSerial comPort, ref MavlinkParse mlParser)
        {
            try
            {
                DateTime endRead = DateTime.Now.AddMilliseconds(100);
                while (comPort != null && comPort.IsOpen && comPort.BytesToRead > 10)
                {
                    int startCnt = comPort.BytesToRead;
                    if (DateTime.Now > endRead) break; // try to break on even packets
                    MAVLinkMessage msg = mlParser.ReadPacket(comPort.BaseStream);
                    if (msg != null)
                    {
                        // Note HB's come with a different comp id, so the seq number sequence is different 

                        //Console.WriteLine("Got " + comPort.PortName + " " + msg.ToString() + "Seq: " + msg.seq + " SeqStep: " + (msg.seq - lastSeq[msg.compid]));
                        forwardMAVLink(msg); 
                        if (gotFirstHB[comNum-1]) updateComStat(comNum,msg.compid,msg.seq);
                        else lastSeq[comNum-1][msg.compid] = msg.seq;

                        if (msg.msgid == (uint)MAVLink.MAVLINK_MSG_ID.HEARTBEAT)
                        {
                            if (gotFirstHB[comNum - 1] == false)
                                Console.WriteLine(comPort.PortName + " got first Heartbeat!");
                            gotFirstHB[comNum - 1] = true;
                            if (comNum == 1) got_hb1 = true; else got_hb2 = true;
                        }

                        if (msg.msgid == (uint)MAVLink.MAVLINK_MSG_ID.FILE_TRANSFER_PROTOCOL)
                            if (comNum == 1) got_ftp1 = true; else got_ftp2 = true;

                        if (msg.msgid == (uint)MAVLink.MAVLINK_MSG_ID.COMMAND_ACK)
                            if (comNum == 1) got_ack1 = true; else got_ack2 = true;

                        //lastSeq[msg.compid] = msg.seq;
                    }
                    bytesRXCount[comNum-1] += startCnt - comPort.BytesToRead;
                }
            } catch (Exception ex)
            {
                Console.WriteLine("Error Reading " + comPort.PortName + " " + ex.ToString());
            }
        }

        private void forwardMAVLink(MAVLinkMessage msg)
        {
            if (msg == null) return;
            if (outputTCP == null || !outputTCP.IsOpen) return;
            outputTCP.Write(msg.buffer, 0, msg.buffer.Length);
        }

        private void forwardCommand(MAVLinkMessage msg)
        {
            // This needs to be built out. Basically, we have to make a smart decision about what port to send commands to. 
            // We may decide it's worth sending some commands to BOTH ports, RTL for example

            if (comPort1 != null && comPort1.IsOpen)
            {
                packetSentCount[0]++;
                bytesTXCount[0] += msg.buffer.Length;
                comPort1.Write(msg.buffer, 0, msg.buffer.Length);
            }
        }

        private void receiveCommands(ref MavlinkParse mlParser)
        {
            try
            {
                DateTime endRead = DateTime.Now.AddMilliseconds(100);
                while (outputTCP != null && outputTCP.IsOpen && outputTCP.BytesToRead > 0)
                {
                    if (DateTime.Now > endRead) break; // try to break on even packets
                    MAVLinkMessage msg = mlParser.ReadPacket(outputTCP.BaseStream);
                    if (msg != null)
                    {
                        //Console.WriteLine("Forwarding Command: " + msg.ToString());

                        forwardCommand(msg);

                        got_tx1 = true;
                    }
                } 

            } catch (Exception ex)
            {
                Console.WriteLine("Error in Receive Command" + ex.ToString());
            }
        }
        

        

        private void mainLoop()
        {
            try
            {
                DateTime lastPrint = DateTime.Now;
                MavlinkParse mlParser1 = new MavlinkParse();
                MavlinkParse mlParser2 = new MavlinkParse();
                MavlinkParse mlParserOut = new MavlinkParse();

                threadrun = true;
                DateTime nextPrintTIme = DateTime.Now.AddSeconds(1);



                while (threadrun)
                {

                    processComChunk(1,ref comPort1, ref mlParser1);
                    processComChunk(2, ref comPort2, ref mlParser2);

                    receiveCommands(ref mlParserOut);
                    if (DateTime.Now >  nextPrintTIme)
                    {
                        Console.WriteLine(DateTime.Now.ToString() + " Status ... ");
                        nextPrintTIme = DateTime.Now.AddSeconds(15);
                    }
                    Thread.Sleep(1);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in Dual Loop: " + ex);
            }
            finally
            {
                threadrun = false;
            }
        }


    }
}
