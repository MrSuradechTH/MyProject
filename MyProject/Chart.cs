using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject
{
    public partial class Chart : Form
    {
        public Chart()
        {
            InitializeComponent();
        }

        private void Chart_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.ShowIcon = false;
            //web.Dock = DockStyle.Fill;
            web.ScriptErrorsSuppressed = true;
            web.Url= new Uri("https://www.google.com");
        }
    }
}
