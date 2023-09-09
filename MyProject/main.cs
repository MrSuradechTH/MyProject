using System;
using System.Diagnostics;
using System.Drawing;
using System.Net.Http.Headers;
using System.Runtime.Caching;
using System.Windows.Forms;

namespace MyProject
{
    public partial class main : Form
    {
        
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.Location = new Point(0, 0);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //int formHeight = this.Height;
            //int formWidth = this.Width;
            //Debug.WriteLine(formWidth.ToString() + ":" + formHeight.ToString());
            password.UseSystemPasswordChar = true;
            servercheck.Start();
            realtime.Start();
        }

        private void main_Closing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Do you want to close the program?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            bool login = true;
            if (string.IsNullOrEmpty(username.Text))
            {
                username.BackColor = Color.Red;
                login = false;
            }
            if (string.IsNullOrEmpty(password.Text))
            {
                password.BackColor = Color.Red;
                login = false;
            }

            if (login)
            {
                string username = this.username.Text, password = this.password.Text;
                string command = $"SELECT * FROM user_information WHERE BINARY Username='{username}' AND BINARY Password='{password}'";

                string[,] data = mysql.query(command);
                //Console.WriteLine(data.Length);

                if (data.Length > 0)
                {
                    //Console.WriteLine("Login success!!!");
                    ShareData.username = username;
                    ShareData.password = password;
                    account.Text = username;
                    this.username.Text = "";
                    this.password.Text = "";
                    this.username.BackColor = Color.White;
                    this.password.BackColor = Color.White;
                    MessageBox.Show($"Welcome back {username} :)", "Login success!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    home home = new home();
                    this.Hide();
                    home.ShowDialog();
                    this.Close();
                    servercheck.Stop();
                    realtime.Stop();
                }
                else
                {
                    //Console.WriteLine("Login fail!!!");
                    this.username.Text = "";
                    this.password.Text = "";
                    MessageBox.Show("Please check username and password again!!!", "Login fail!!!", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void server_name_Click(object sender, EventArgs e)
        {

        }

        public void server_check(object sender, EventArgs e)
        {
            server_name.Text = mysql.server;
            server_status.Text = mysql.Connection();
            if (server_status.Text == "Server status : Connected")
            {
                panel.BackColor = Color.Lime;
            }else
            {
                panel.BackColor= Color.Red;
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login.Focus();
                login_Click(null,null);
            }
        }

        private void username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                password.Focus();
            }
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(username.Text))
            {
                username.BackColor = Color.White;
            }else
            {
                username.BackColor = Color.Red;
            }
        }

        private void password_TextChanged_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(password.Text))
            {
                password.BackColor = Color.White;
            }
            else
            {
                password.BackColor = Color.Red;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void main_Resize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.Location = new Point(0, 0);
        }

        private void Realtime(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            date_time.Text = now.ToString();
            if (ShareData.debugmode)
            {
                Console.WriteLine(now);
            }
        }

        private void account_Click(object sender, EventArgs e)
        {

        }

        private void server_status_Click(object sender, EventArgs e)
        {

        }
    }
}
