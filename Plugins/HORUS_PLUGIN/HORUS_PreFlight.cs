﻿using System;
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
    public partial class HORUS_PreFlight : UserControl
    {
        private int messagecount;
        private Plugin.PluginHost _host = null;
        private HORUS_Panel _panel = null;
        private Dual_Serial_Ports _dsp = null;
        public HORUS_PreFlight()
        {
            InitializeComponent();

            timer1.Start();
            timer2.Start();







        }


        private void cb_openHORUSPanel_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_openHORUSPanel.Checked)
            {
                try
                {
                    if (_panel == null)
                {
                    _panel = new HORUS_Panel();
                    _panel.setHost(_host); 
                }

                
                    _panel.Anchor = AnchorStyles.Right | AnchorStyles.Top;

                    _host.MainForm.Invoke((Action)(() =>
                    {
                        _host.FDGMapControl.Controls.Add(_panel);
                        _panel.Location = new System.Drawing.Point(_host.FDGMapControl.Width - _panel.Width - 10, 25);
                        _panel.setHost(_host);
                    }));
                }
                catch
                {
                    cb_openHORUSPanel.Checked = false;

                }
            }

            Settings.Instance["horus_panel_visible"] = cb_openHORUSPanel.Checked.ToString();
        }

        public void setHost(Plugin.PluginHost host)
        {
            _host = host;
        }

        private void BUT_arm_Click(object sender, EventArgs e)
        {
            if (!MainV2.comPort.BaseStream.IsOpen)
                return;

            // arm the MAV
            try
            {
                var isitarmed = MainV2.comPort.MAV.cs.armed;
                var action = MainV2.comPort.MAV.cs.armed ? "Disarm" : "Arm";

                if (isitarmed)
                    if (CustomMessageBox.Show("Are you sure you want to " + action, action,
                            CustomMessageBox.MessageBoxButtons.YesNo) !=
                        CustomMessageBox.DialogResult.Yes)
                        return;
                StringBuilder sb = new StringBuilder();
                var sub = MainV2.comPort.SubscribeToPacketType(MAVLink.MAVLINK_MSG_ID.STATUSTEXT, message =>
                {
                    sb.AppendLine(Encoding.ASCII.GetString(((MAVLink.mavlink_statustext_t)message.data).text)
                        .TrimEnd('\0'));
                    return true;
                }, (byte)MainV2.comPort.sysidcurrent, (byte)MainV2.comPort.compidcurrent);
                bool ans = MainV2.comPort.doARM(!isitarmed);
                MainV2.comPort.UnSubscribeToPacketType(sub);
                if (ans == false)
                {
                    if (CustomMessageBox.Show(
                            action + " failed.\n" + sb.ToString() + "\nForce " + action +
                            " can bypass safety checks,\nwhich can lead to the vehicle crashing\nand causing serious injuries.\n\nDo you wish to Force " +
                            action + "?", Strings.ERROR, CustomMessageBox.MessageBoxButtons.YesNo,
                            CustomMessageBox.MessageBoxIcon.Exclamation, "Force " + action, "Cancel") ==
                        CustomMessageBox.DialogResult.Yes)
                    {
                        ans = MainV2.comPort.doARM(!isitarmed, true);
                        if (ans == false)
                        {
                            CustomMessageBox.Show(Strings.ErrorRejectedByMAV, Strings.ERROR);
                        }
                    }
                }
            }
            catch
            {
                CustomMessageBox.Show(Strings.ErrorNoResponce, Strings.ERROR);
            }
        }

        private void BUT_arm_Click_old(object sender, EventArgs e)
        {
            if (!MainV2.comPort.BaseStream.IsOpen)
                return;

            // arm the MAV
            try
            {
                // This entire logic block needs to be rebuilt for newer arming procedure. 

                //var isitarmed = MainV2.comPort.MAV.cs.armed;
                //var action = MainV2.comPort.MAV.cs.armed ? "Disarm" : "Arm";

                //if (isitarmed)
                //    if (CustomMessageBox.Show("Are you sure you want to " + action, action,
                //            CustomMessageBox.MessageBoxButtons.YesNo) !=
                //        CustomMessageBox.DialogResult.Yes)
                //        return;
                //StringBuilder sb = new StringBuilder();
                ////var sub = MainV2.comPort.SubscribeToPacketType(MAVLink.MAVLINK_MSG_ID.STATUSTEXT, message =>
                ////{
                ////    sb.AppendLine(Encoding.ASCII.GetString(((MAVLink.mavlink_statustext_t)message.data).text)
                ////        .TrimEnd('\0'));
                ////    return true;
                ////});
                //bool ans = MainV2.comPort.doARM(!isitarmed);
                //MainV2.comPort.UnSubscribeToPacketType(sub);
                //if (ans == false)
                //{
                //    if (CustomMessageBox.Show(
                //            action + " failed.\n" + sb.ToString() + "\nForce " + action +
                //            " can bypass safety checks,\nwhich can lead to the vehicle crashing\nand causing serious injuries.\n\nDo you wish to Force " +
                //            action + "?", Strings.ERROR, CustomMessageBox.MessageBoxButtons.YesNo,
                //            CustomMessageBox.MessageBoxIcon.Exclamation, "Force " + action, "Cancel") ==
                //        CustomMessageBox.DialogResult.Yes)
                //    {
                //        ans = MainV2.comPort.doARM(!isitarmed, true);
                //        if (ans == false)
                //        {
                //            CustomMessageBox.Show(Strings.ErrorRejectedByMAV, Strings.ERROR);
                //        }
                //    }
                //}
            }
            catch
            {
                CustomMessageBox.Show(Strings.ErrorNoResponce, Strings.ERROR);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Settings.Instance.GetBoolean("horus_panel_visible") && _host != null && _host.comPort != null && _host.comPort.MAV != null)
            {
                cb_openHORUSPanel.Checked = true;
            }


            try
            {
                bool isModeReady = (MainV2.comPort.MAV.cs.mode == "Manual" || MainV2.comPort.MAV.cs.mode == "FBWA" || MainV2.comPort.MAV.cs.mode == "FBWB");
                BUT_arm.Enabled = (MainV2.comPort.MAV.cs.armed || isModeReady);

                CB_notFlying.Checked = (MainV2.comPort.MAV.cs.timeSinceArmInAir > 0) ? false : true;
                CB_notFlying.BackColor = CB_notFlying.Checked ? Color.Green : Color.Red;

                CB_IsArmed.Checked = MainV2.comPort.MAV.cs.armed;
                CB_IsArmed.BackColor = CB_IsArmed.Checked ? Color.Green : Color.Red;

                CB_notAuto.Checked = isModeReady;
                CB_notAuto.BackColor = CB_notAuto.Checked ? Color.Green : Color.Red;

                CB_pilotReady.Enabled = (CB_pilotReady.Checked || (CB_notFlying.Checked && CB_IsArmed.Checked && CB_notAuto.Checked)) ? true : false;
                

                if (CB_pilotReady.Checked && (!CB_notFlying.Checked || !CB_pilotReady.Checked || !CB_IsArmed.Checked)) CB_pilotReady.Checked = false;

                if (CB_pilotReady.Checked && CB_paco_rdy.Checked && CB_payload_rdy.Checked ) BUT_SET_AUTO.Enabled = true;
            } catch
            {

            }



            if (true) // MainV2.instance.FlightData.isPreFlightSelected()) //MainV2.instance.FlightData.tabControlactions.SelectedTab == MainV2.instance.FlightData.IRISS_PreFlight)
            {

                var messagetime = MainV2.comPort.MAV.cs.messages.LastOrDefault().time;
                if (messagecount != messagetime.toUnixTime())
                {
                    try
                    {
                        StringBuilder message = new StringBuilder();
                        MainV2.comPort.MAV.cs.messages.ForEach(x =>
                        {
                            message.Insert(0, x.Item1.ToString("hh:mm:ss") + " : " + x.Item2 + "\n");
                        });
                        TXT_msgBox.Text = message.ToString();

                        messagecount = messagetime.toUnixTime();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error in messages IRISS PreFlight");
                    }
                }



                //var isitarmed = MainV2.comPort.MAV.cs.armed;
                BUT_arm.Text = MainV2.comPort.MAV.cs.armed ? "DISARM" : "ARM";
                

            }


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (MainV2.comPort.BaseStream != null && MainV2.comPort.BaseStream.IsOpen)
            {
                lblParams.Text = "Imporant Settings: \r\n";

                displayParamVal("ALT_HOLD_RTL", "cm");
                displayParamVal("RTL_RADIUS", "m (opt)");
                displayParamVal("WP_LOITER_RAD", "m");
                displayParamVal("SERVO9_FUNCTION", "(== 27)");
                displayParamVal("CHUTE_CHANNEL", "(== 6)");

                displayParamVal("AFS_ENABLE", "");
                displayParamVal("AFS_TERM_ACTION", "");
                displayParamVal("FENCE_AUTOENABLE", "");
                displayParamVal("FENCE_ACTION", "");
                displayParamVal("FS_GCS_ENABL", "");
                displayParamVal("THR_FAILSAFE", "");
                displayParamVal("FS_SHORT_ACTN", "");
                displayParamVal("FS_LONG_ACTN", "");
                displayParamVal("SYSID_THISMAV", "");

                displayParamVal("PUP_ELEV_OFS", "");
                displayParamVal("PUP_NG_LIM", "");
                displayParamVal("PUP_NG_JERK_LIM", "");
                displayParamVal("PUP_PITCH_CD", "");

                displayParamVal("SCR_USER1", "(MFS on)");
                displayParamVal("SCR_USER2", "(mar. buf)");
                displayParamVal("SCR_USER3", "(Cht Rls Alt)");
                displayParamVal("SCR_USER4", "(Spd Sch On)");

                displayParamVal("TERRAIN_ENABLE", "");

            }
            else
            {
                lblParams.Text = "Not Connected.";
            }
        }

        private void displayParamVal(String valName, String units)
        {
            if (MainV2.comPort.MAV.param.ContainsKey(valName))
            {
                lblParams.Text += valName.PadRight(16) +
                                  MainV2.comPort.MAV.param[valName].ToString().PadLeft(8) +
                                  " " +
                                  units.PadRight(10) +
                                  "\n";
            } else
            {
                //Console.WriteLine("No Param: " + valName);
            }
        }

        private void BUT_asCal_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                CustomMessageBox.Show("Are you sure you want to Zero Sensors?", "Action",
                    MessageBoxButtons.YesNo) == (int)DialogResult.Yes)
                {
                    

                    int param1 = 0;
                    int param2 = 0;
                    int param3 = 1;

                    var cmd = (MAVLink.MAV_CMD)Enum.Parse(typeof(MAVLink.MAV_CMD), "PREFLIGHT_CALIBRATION");

                    if (MainV2.comPort.doCommand(cmd, param1, param2, param3, 0, 0, 0, 0))
                    {

                    }
                    else
                    {
                        CustomMessageBox.Show(Strings.CommandFailed + " " + cmd, Strings.ERROR);
                    }
                }
            }
            catch
            {
                CustomMessageBox.Show(Strings.CommandFailed, Strings.ERROR);
            }
        }


        private void BUT_loadTO_Click(object sender, EventArgs e) 
        {
            //MainV2.instance.FlightData.flightPlannerToolStripMenuItem_Click(sender, e);


            //MainV2.instance.FlightPlanner.BUT_read_Click(sender, e);

            //MainV2.instance.FlightPlanner.clearMissionToolStripMenuItem_Click(sender, e);

            //MainV2.instance.FlightPlanner.takeoffToolStripMenuItem_Click(sender, e);

            //MainV2.instance.MyView.ShowScreen("FlightPlanner");
            //MainV2.instance.FlightPlanner.loadTORAAVEN(sender, e);
            //MainV2.instance.MyView.ShowScreen("FlightData");

            //MainV2.instance.FlightPlanner.BUT_write_Click(sender, e);

            //MainV2.instance.FlightData.close_planner(sender,e);

        }

        private void BUT_SET_AUTO_Click(object sender, EventArgs e)
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

            ((Control)sender).Enabled = false;

            CB_paco_rdy.Checked = false;
            CB_payload_rdy.Checked = false;

        }

        private void but_openDSP_Click(object sender, EventArgs e)
        {
            if (_dsp ==  null)
            {
                _dsp = new Dual_Serial_Ports();
            }
            _dsp.Show();
        }
    }
}

