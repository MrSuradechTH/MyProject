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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void stockListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stock_list st = new stock_list();
            st.MdiParent = this;
            st.Show();
            WindowState = FormWindowState.Maximized;
        }

        private void home_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.Location = new Point(0, 0);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            account.Text = ShareData.username;
            stock_list st = new stock_list();
            st.MdiParent = this;
            st.Show();
            WindowState = FormWindowState.Maximized;
            servercheck.Start();
            realtime.Start();
        }

        private void home_Resize(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void chartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chart ch = new Chart();
            ch.MdiParent = this;
            ch.Show();
            WindowState = FormWindowState.Maximized;
        }

        private void servercheck_Tick(object sender, EventArgs e)
        {
            server_name.Text = mysql.server;
            server_status.Text = mysql.Connection();
            if (server_status.Text == "Server status : Connected")
            {
                panel.BackColor = Color.Lime;
            }
            else
            {
                panel.BackColor = Color.Red;
            }
        }

        private void realtime_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            date_time.Text = now.ToString();
            if (ShareData.debugmode)
            {
                Console.WriteLine(now);
            }
        }
    }
}
