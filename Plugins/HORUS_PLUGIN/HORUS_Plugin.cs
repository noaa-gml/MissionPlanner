using MissionPlanner.Grid;
using System;
using System.Windows.Forms;
using MissionPlanner.Controls;
using MissionPlanner.Utilities;
using SharpKml.Dom.Atom;

namespace HORUS_plugin_Plugin
{
    public class HORUS_plugin_Plugin : MissionPlanner.Plugin.Plugin
    {
        //TabPage
        private System.Windows.Forms.TabPage tab = new System.Windows.Forms.TabPage();
        private System.Windows.Forms.TabPage tab2 = new System.Windows.Forms.TabPage();
        private TabControl tabctrl;
        private HORUS_PreFlight pf = new HORUS_PreFlight();
        private HORUSControlMode controlMode = new HORUSControlMode();
        private MAVLinkInspectorControl mavLink = null;
        

        public override string Name
        {
            get { return "HORUS Control"; }
        }

        public override string Version
        {
            get { return "0.01"; }
        }

        public override string Author
        {
            get { return "Steven Borenstein"; }
        }

        public override bool Init()
        {
            return true;
        }

        public override bool Loaded()
        {
            forceSettings();

            pf.setHost(Host);

            mavLink = new MAVLinkInspectorControl(Host.comPort);



            //TODO Uncomment once Beta is updates
            Host.MainForm.FlightData.TabListOriginal.Add(tab);
            Host.MainForm.FlightData.TabListOriginal.Add(tab2);

            tabctrl = Host.MainForm.FlightData.tabControlactions;
            // set the display name
            tab.Text = "HORUS-Preflight";
            tab2.Text = "MAVLink";
            // set the internal id
            tab.Name = "HORUS_PF";
            tab2.Name = "MAVLink";
            // add the usercontrol to the tabpage

            tab.Controls.Add(pf);
            tab2.Controls.Add(mavLink);

            tabctrl.TabPages.Insert(5, tab2);
            tabctrl.TabPages.Insert(5, tab);

            ThemeManager.ApplyThemeTo(tab);
            ThemeManager.ApplyThemeTo(tab2);

            return true;
        }


        private void forceSettings()
        {
            

            string tabs = Settings.Instance["tabcontrolactions"];

            // setup default if doesnt exist
            if (tabs == null)
            {
                CustomMessageBox.Show("Restart Mission Planner to enable HORUS Tab. Disable Plugin if Not Required CTRL-P");
                Host.MainForm.FlightData.saveTabControlActions();
                tabs = Settings.Instance["tabcontrolactions"];
                Settings.Instance.Save();
            }
        }


        public override bool Exit()
        {
            return true;
        }
    }
}
