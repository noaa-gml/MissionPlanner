﻿using MissionPlanner.Grid;
using System;
using System.Windows.Forms;
using MissionPlanner.Controls;
using MissionPlanner.Utilities;

namespace HORUS_plugin_Plugin
{
    public class HORUS_plugin_Plugin : MissionPlanner.Plugin.Plugin
    {
        //TabPage
        private System.Windows.Forms.TabPage tab = new System.Windows.Forms.TabPage();
        private TabControl tabctrl;
        

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



            //TODO Uncomment once Beta is updates
            //Host.MainForm.FlightData.TabListOriginal.Add(tab);

            tabctrl = Host.MainForm.FlightData.tabControlactions;
            // set the display name
            tab.Text = "HORUS Preflight";
            // set the internal id
            tab.Name = "HORUS_PF";
            // add the usercontrol to the tabpage

            tabctrl.TabPages.Insert(5, tab);

            //Host.MainForm.FlightPlanner.updateDisplayView();

            ThemeManager.ApplyThemeTo(tab);

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
