namespace MyProject
{
    partial class home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aleartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.account = new System.Windows.Forms.Label();
            this.server_name = new System.Windows.Forms.Label();
            this.server_status = new System.Windows.Forms.Label();
            this.date_time = new System.Windows.Forms.Label();
            this.servercheck = new System.Windows.Forms.Timer(this.components);
            this.realtime = new System.Windows.Forms.Timer(this.components);
            this.MenuStrip.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1063, 43);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            this.MenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            this.MenuStrip.Resize += new System.EventHandler(this.home_Resize);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockListToolStripMenuItem,
            this.aleartToolStripMenuItem,
            this.chartToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(92, 39);
            this.menuToolStripMenuItem.Text = "menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // stockListToolStripMenuItem
            // 
            this.stockListToolStripMenuItem.Name = "stockListToolStripMenuItem";
            this.stockListToolStripMenuItem.Size = new System.Drawing.Size(207, 40);
            this.stockListToolStripMenuItem.Text = "Stock List";
            this.stockListToolStripMenuItem.Click += new System.EventHandler(this.stockListToolStripMenuItem_Click);
            // 
            // aleartToolStripMenuItem
            // 
            this.aleartToolStripMenuItem.Name = "aleartToolStripMenuItem";
            this.aleartToolStripMenuItem.Size = new System.Drawing.Size(207, 40);
            this.aleartToolStripMenuItem.Text = "Aleart";
            // 
            // chartToolStripMenuItem
            // 
            this.chartToolStripMenuItem.Name = "chartToolStripMenuItem";
            this.chartToolStripMenuItem.Size = new System.Drawing.Size(207, 40);
            this.chartToolStripMenuItem.Text = "Chart";
            this.chartToolStripMenuItem.Click += new System.EventHandler(this.chartToolStripMenuItem_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Red;
            this.panel.Controls.Add(this.pictureBox1);
            this.panel.Controls.Add(this.account);
            this.panel.Controls.Add(this.server_name);
            this.panel.Controls.Add(this.server_status);
            this.panel.Controls.Add(this.date_time);
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.Location = new System.Drawing.Point(0, 287);
            this.panel.Margin = new System.Windows.Forms.Padding(0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1063, 100);
            this.panel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(3, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // account
            // 
            this.account.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.account.BackColor = System.Drawing.Color.White;
            this.account.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.account.Location = new System.Drawing.Point(63, 30);
            this.account.Margin = new System.Windows.Forms.Padding(0);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(350, 50);
            this.account.TabIndex = 8;
            this.account.Text = "Please Login";
            this.account.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // server_name
            // 
            this.server_name.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.server_name.BackColor = System.Drawing.Color.White;
            this.server_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.server_name.Location = new System.Drawing.Point(710, 2);
            this.server_name.Margin = new System.Windows.Forms.Padding(0);
            this.server_name.Name = "server_name";
            this.server_name.Size = new System.Drawing.Size(350, 45);
            this.server_name.TabIndex = 7;
            this.server_name.Text = "xxx.xxx.xxx.xxx";
            this.server_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // server_status
            // 
            this.server_status.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.server_status.BackColor = System.Drawing.Color.White;
            this.server_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.server_status.Location = new System.Drawing.Point(710, 47);
            this.server_status.Margin = new System.Windows.Forms.Padding(0);
            this.server_status.Name = "server_status";
            this.server_status.Size = new System.Drawing.Size(350, 45);
            this.server_status.TabIndex = 1;
            this.server_status.Text = "Server status : xxxxx";
            this.server_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // date_time
            // 
            this.date_time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.date_time.BackColor = System.Drawing.Color.White;
            this.date_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_time.Location = new System.Drawing.Point(290, 30);
            this.date_time.Margin = new System.Windows.Forms.Padding(0);
            this.date_time.Name = "date_time";
            this.date_time.Size = new System.Drawing.Size(400, 50);
            this.date_time.TabIndex = 0;
            this.date_time.Text = "XX/XX/XXXX XX:XX:XX";
            this.date_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // servercheck
            // 
            this.servercheck.Interval = 5000;
            this.servercheck.Tick += new System.EventHandler(this.servercheck_Tick);
            // 
            // realtime
            // 
            this.realtime.Interval = 500;
            this.realtime.Tick += new System.EventHandler(this.realtime_Tick);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 387);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.MenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "home";
            this.Text = "home";
            this.Load += new System.EventHandler(this.home_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aleartToolStripMenuItem;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label account;
        private System.Windows.Forms.Label server_name;
        private System.Windows.Forms.Label server_status;
        private System.Windows.Forms.Label date_time;
        public System.Windows.Forms.Timer servercheck;
        private System.Windows.Forms.Timer realtime;
    }
}