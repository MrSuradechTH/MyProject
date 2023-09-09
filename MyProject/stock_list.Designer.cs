namespace MyProject
{
    partial class stock_list
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stock_list));
            this.refresh = new System.Windows.Forms.Timer(this.components);
            this.AddPanel = new System.Windows.Forms.Panel();
            this.add = new System.Windows.Forms.Button();
            this.stockname = new System.Windows.Forms.TextBox();
            this.Stock_GridView = new System.Windows.Forms.DataGridView();
            this.AddPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Stock_GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // refresh
            // 
            this.refresh.Interval = 10000;
            this.refresh.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AddPanel
            // 
            this.AddPanel.Controls.Add(this.add);
            this.AddPanel.Controls.Add(this.stockname);
            this.AddPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddPanel.Location = new System.Drawing.Point(0, 0);
            this.AddPanel.Name = "AddPanel";
            this.AddPanel.Size = new System.Drawing.Size(800, 103);
            this.AddPanel.TabIndex = 2;
            // 
            // add
            // 
            this.add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.add.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(309, 26);
            this.add.Margin = new System.Windows.Forms.Padding(0);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(200, 50);
            this.add.TabIndex = 7;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // stockname
            // 
            this.stockname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stockname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stockname.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockname.Location = new System.Drawing.Point(20, 25);
            this.stockname.Margin = new System.Windows.Forms.Padding(0);
            this.stockname.Name = "stockname";
            this.stockname.Size = new System.Drawing.Size(200, 55);
            this.stockname.TabIndex = 6;
            // 
            // Stock_GridView
            // 
            this.Stock_GridView.AllowUserToAddRows = false;
            this.Stock_GridView.AllowUserToDeleteRows = false;
            this.Stock_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Stock_GridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Stock_GridView.Location = new System.Drawing.Point(0, 103);
            this.Stock_GridView.Name = "Stock_GridView";
            this.Stock_GridView.ReadOnly = true;
            this.Stock_GridView.RowHeadersWidth = 51;
            this.Stock_GridView.RowTemplate.Height = 24;
            this.Stock_GridView.Size = new System.Drawing.Size(800, 347);
            this.Stock_GridView.TabIndex = 3;
            this.Stock_GridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Stock_GridView_CellContentClick);
            // 
            // stock_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Stock_GridView);
            this.Controls.Add(this.AddPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "stock_list";
            this.Text = "stock_list";
            this.Load += new System.EventHandler(this.StockList_Load);
            this.AddPanel.ResumeLayout(false);
            this.AddPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Stock_GridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer refresh;
        private System.Windows.Forms.Panel AddPanel;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox stockname;
        private System.Windows.Forms.DataGridView Stock_GridView;
    }
}