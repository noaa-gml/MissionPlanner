using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MissionPlanner.Utilities;

namespace MissionPlanner.Controls
{
    public partial class HORUSControlMode : UserControl
    {
        int alt_requested;
        DateTime alt_time;

        public HORUSControlMode()
        {
            InitializeComponent();
        }

        private void IRISSControlMode_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }

        private void setRTL_Click(object sender, EventArgs e)
        {
            try
            {
                ((Control)sender).Enabled = false;
                MainV2.comPort.setMode("RTL");
            }
            catch
            {
                CustomMessageBox.Show(Strings.CommandFailed, Strings.ERROR);
            }

            ((Control)sender).Enabled = true;
        }

        private void setGuided_Click(object sender, EventArgs e)
        {
            try
            {
                ((Control)sender).Enabled = false;
                MainV2.comPort.setMode("Guided");
            }
            catch
            {
                CustomMessageBox.Show(Strings.CommandFailed, Strings.ERROR);
            }

            ((Control)sender).Enabled = true;
        }

        private void setAuto_Click(object sender, EventArgs e)
        {
            try
            {
                ((Control)sender).Enabled = false;
                MainV2.comPort.setMode("Auto");
            }
            catch
            {
                CustomMessageBox.Show(Strings.CommandFailed, Strings.ERROR);
            }

            ((Control)sender).Enabled = true;
        }

        private void setFBWA_Click(object sender, EventArgs e)
        {
            try
            {
                ((Control)sender).Enabled = false;
                MainV2.comPort.setMode("FBWA");
            }
            catch
            {
                CustomMessageBox.Show(Strings.CommandFailed, Strings.ERROR);
            }

            ((Control)sender).Enabled = true;
        }

        private void setAlt(int newalt)
        {
            alt_time = DateTime.Now;

            if (newalt < 25.0)
            {
                CustomMessageBox.Show("This button does not allow SP < 25m", Strings.ERROR);
                return;
            }
            alt_requested = newalt; 



            Console.WriteLine("Sending standard height command from alt button.");

            try
            {
                MainV2.comPort.setNewWPAlt(new Locationwp { alt = newalt / CurrentState.multiplieralt });
            }
            catch
            {
                CustomMessageBox.Show(Strings.ErrorCommunicating, Strings.ERROR);
            }
        }

        private void BUT_ALT_100_Click(object sender, EventArgs e)
        {
            setAlt(100);
        }


        private void BUT_ALT_200_Click(object sender, EventArgs e)
        {
            setAlt(200);
        }

        private void BUT_ALT_300_Click(object sender, EventArgs e)
        {
            setAlt(300);
        }

        private void BUT_ALT_400_Click(object sender, EventArgs e)
        {
            setAlt(400);
        }

        private void BUT_ALT_500_Click(object sender, EventArgs e)
        {
            setAlt(500);
        }

        private void BUT_ALT_P50_Click(object sender, EventArgs e)
        {
            setAlt(alt_requested + 50);
        }
        private void BUT_ALT_M50_Click(object sender, EventArgs e)
        {
            
            if (alt_requested > 75)
            {
                setAlt(alt_requested - 50);
            }
        }



        private void myButton1_Click(object sender, EventArgs e)
        {
            // command balloon release
        }
    }
}
