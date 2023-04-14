using AviFile;
using IronPython.Runtime.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MissionPlanner
{
    public partial class HORUS_Panel : UserControl
    {
        private Plugin.PluginHost _host = null;
        int packetRate;
        int byteRate;
        int packetCount;
        int byteCount;
        int packetCounter;

        int hb_counter = 1; 

        private MAVLinkInterface mav;

        public HORUS_Panel()
        {
            InitializeComponent();
            timer1.Start();

            
            ledHB.On = false;
        }

        public void setHost(Plugin.PluginHost host)
        {
            _host = host;

            this.mav = _host.comPort;
            this.mav.OnPacketReceived += MavOnOnPacketReceived;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            printAHRS();
            printGliderStats();
            printCommStats();
        }


        private void printCommStats()
        {
            try
            {
                if (packetCounter++ >= (5000/timer1.Interval))
                {
                    packetRate = packetCount/5;
                    byteRate = byteCount/5; 
                    packetCount = 0;
                    byteCount = 0;
                    packetCounter = 0;
                }

                if (hb_counter == 0) { ledHB.On = true; }
                if (hb_counter > 0) { ledHB.On = false; }
                hb_counter++; 

                lblCommStats.Text = "Byte Rate: ".PadRight(14) +
                               byteRate.ToString().PadLeft(8) + " bps\n";
                lblCommStats.Text += "Packet Rate: ".PadRight(14) +
                               packetRate.ToString().PadLeft(8) + " pps\n";
                lblCommStats.Text += "RX Error: ".PadRight(14) +
                                _host.cs.rxerrors.ToString().PadLeft(8) + "\n"; 
                lblCommStats.Text += "TX Buffer: ".PadRight(14) +
                                _host.cs.txbuffer.ToString().PadLeft(8) + "\n";
                lblCommStats.Text += "Last HB: ".PadRight(14) +
                               ((float) hb_counter / (1000/timer1.Interval)).ToString("0.0").PadLeft(8) + " sec\n";
            }
            catch
            {
                lblCommStats.Text = "Waiting for Data.";
            }
        }

 

        private void MavOnOnPacketReceived(object o, MAVLink.MAVLinkMessage linkMessage)
        {
            byteCount += linkMessage.Length;
            packetCount++;
            if (linkMessage.msgid == (uint) MAVLink.MAVLINK_MSG_ID.HEARTBEAT) 
                hb_counter = 0; 
        }


        private void printAHRS()
        {
            try
            {
                // Print ACC
                lblAHRS1.Text = "AHRS YPR:".PadRight(10) +
                                _host.cs.yaw.ToString("0").PadRight(5) + 
                                _host.cs.pitch.ToString("0").PadRight(5) +
                                _host.cs.roll.ToString("0").PadRight(5) ;

                if (_host.cs.pitch > (Math.Abs(_host.cs.roll)))
                {
                    lblAHRS1.Text += "Pitch Up\n";
                }
                else if (-_host.cs.pitch > (Math.Abs(_host.cs.roll)))
                {
                    lblAHRS1.Text += "Pitch Down\n";
                }
                else if (_host.cs.roll > (Math.Abs(_host.cs.pitch)))
                {
                    lblAHRS1.Text += "RW Down\n";
                }
                else if (-_host.cs.roll > (Math.Abs(_host.cs.pitch)))
                {
                    lblAHRS1.Text += "LW Down\n";
                }

                // Print Mag
                lblAHRS1.Text += "MAG XYZ:".PadRight(10) +
                                _host.cs.mx.ToString("0").PadRight(5) +
                                _host.cs.my.ToString("0").PadRight(5) +
                                _host.cs.mz.ToString("0").PadRight(5);
                if (_host.cs.mz > (Math.Abs(_host.cs.mx) + Math.Abs(_host.cs.my)))
                {
                    lblAHRS1.Text += "Top Up\n";
                }
                else if (-_host.cs.mz > (Math.Abs(_host.cs.mx) + Math.Abs(_host.cs.my)))
                {
                    lblAHRS1.Text += "Inverted\n";
                }
                else if (_host.cs.mx > (Math.Abs(_host.cs.mz) + Math.Abs(_host.cs.my)))
                {
                    lblAHRS1.Text += "Nose Down\n";
                }
                else if (-_host.cs.mx > (Math.Abs(_host.cs.mz) + Math.Abs(_host.cs.my)))
                {
                    lblAHRS1.Text += "Nose Up\n";
                }
                else if (_host.cs.my > (Math.Abs(_host.cs.mz) + Math.Abs(_host.cs.mx)))
                {
                    lblAHRS1.Text += "RW Down\n";
                }
                else if (-_host.cs.my > (Math.Abs(_host.cs.mz) + Math.Abs(_host.cs.mx)))
                {
                    lblAHRS1.Text += "LW Down\n";
                }
                else
                {
                    lblAHRS1.Text += "UNK\n";
                }

                // Print ACC
                lblAHRS1.Text += "ACC XYZ:".PadRight(10) +
                                _host.cs.ax.ToString("0").PadRight(5) +
                                _host.cs.ay.ToString("0").PadRight(5) +
                                _host.cs.az.ToString("0").PadRight(5);
                if (-_host.cs.az > (Math.Abs(_host.cs.ax) + Math.Abs(_host.cs.ay)))
                {
                    lblAHRS1.Text += "Top Up\n";
                }
                else if (_host.cs.az > (Math.Abs(_host.cs.ax) + Math.Abs(_host.cs.ay)))
                {
                    lblAHRS1.Text += "Inverted\n";
                }
                else if (-_host.cs.ax > (Math.Abs(_host.cs.az) + Math.Abs(_host.cs.ay)))
                {
                    lblAHRS1.Text += "Nose Down\n";
                }
                else if (_host.cs.ax > (Math.Abs(_host.cs.az) + Math.Abs(_host.cs.ay)))
                {
                    lblAHRS1.Text += "Nose Up\n";
                }
                else if (_host.cs.ay > (Math.Abs(_host.cs.az) + Math.Abs(_host.cs.ax)))
                {
                    lblAHRS1.Text += "LW Down\n";
                }
                else if (-_host.cs.ay > (Math.Abs(_host.cs.az) + Math.Abs(_host.cs.ax)))
                {
                    lblAHRS1.Text += "RW Down\n";
                }
                else
                {
                    lblAHRS1.Text += "UNK\n";
                }



                lblAHRS1.Text += "EKF STAT:".PadRight(10) + _host.cs.ekfstatus + "\n";
                lblAHRS1.Text += "EKF FLAG:".PadRight(10) + Convert.ToString(_host.cs.ekfflags,2).PadLeft(16, '0') + "\n";


            }
            catch
            {
                lblAHRS1.Text = "Waiting for Data.";
            }
        }

        private void printGliderStats()
        {
            try
            {
                lblGliderCalcs.Text =  "DTH:".PadRight(10) + _host.cs.DistToHome.ToString("0.0") + " " + CurrentState.DistanceUnit + "\n";
                lblGliderCalcs.Text += "GS:".PadRight(10) + _host.cs.groundspeed.ToString("0.0") + " " + CurrentState.SpeedUnit +  "\n";
                lblGliderCalcs.Text += "VS:".PadRight(10) + _host.cs.verticalspeed_fpm.ToString("0.0") + " fpm " + (_host.cs.verticalspeed_fpm* 0.00508).ToString("0.0") + " m/s" + "\n";
                if (_host.cs.vz > 0)
                {
                    // assumes mph, fpm for now
                    lblGliderCalcs.Text += "GStoHOME:".PadRight(10) + ((_host.cs.DistToHome / _host.cs.groundspeed)*60.0).ToString("0.0") + " min\n";
                    lblGliderCalcs.Text += "VZtoHOME:".PadRight(10) + ((_host.cs.alt / -_host.cs.vz)).ToString("0.0") + " min\n";
                }
                

            }
            catch
            {
                lblAHRS1.Text = "Waiting for Data.";
            }
        }
    }
}
