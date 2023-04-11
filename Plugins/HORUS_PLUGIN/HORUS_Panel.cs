using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MissionPlanner
{
    public partial class HORUS_Panel : UserControl
    {
        private Plugin.PluginHost _host = null;

        public HORUS_Panel()
        {
            InitializeComponent();
        }

        public void setHost(Plugin.PluginHost host)
        {
            _host = host;
        }
    }
}
