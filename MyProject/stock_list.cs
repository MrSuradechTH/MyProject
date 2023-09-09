using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace MyProject
{
    public partial class stock_list : Form
    {
        public stock_list()
        {
            InitializeComponent();
        }

        public dynamic MakeColumns(string header, string name, Type datatype = null,string columntype = "Normal")
        {
            if (columntype == "Normal")
            {
                DataGridViewTextBoxColumn value = new DataGridViewTextBoxColumn();
                value.HeaderText = header;
                value.Name = name;
                value.ValueType = datatype;

                return value;
            }
            else if (columntype == "Button")
            {
                DataGridViewButtonColumn value = new DataGridViewButtonColumn();
                value.HeaderText = header;
                value.Name = name;
                value.Text = name;
                value.UseColumnTextForButtonValue = true;

                return value;
            }
            
            return null;
        }
        private void StockList_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.ShowIcon = false;
            string command = $"SELECT Stock_list_data FROM stock_data WHERE BINARY Username='{ShareData.username}'";

            string[,] data = mysql.query(command);

            List<StockList> jsondecode = JsonConvert.DeserializeObject<List<StockList>>(data[0,0]);

            Stock_GridView.Visible = false;
            AddPanel.Visible = false;
            WindowState = FormWindowState.Maximized;

            AddPanel.Dock = DockStyle.Bottom;
            AddPanel.Height = 100;


            Stock_GridView.Dock = DockStyle.Fill;
            Stock_GridView.RowHeadersVisible = false;
            Stock_GridView.ScrollBars = ScrollBars.Vertical;
            Stock_GridView.DefaultCellStyle.Font = new Font("Arial", 20);
            Stock_GridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 25,  FontStyle.Bold);
            Stock_GridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
            Stock_GridView.AllowUserToResizeColumns = false;
            Stock_GridView.AllowUserToResizeRows = false;
            Stock_GridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Stock_GridView.Columns.Add(MakeColumns(header: "Name", name: "Name", datatype: typeof(string)));
            Stock_GridView.Columns.Add(MakeColumns(header: "Price", name: "Price", datatype: typeof(string)));
            Stock_GridView.Columns.Add(MakeColumns(header: "Delete", name: "Delete", columntype: "Button"));
            
            Stock_GridView.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            foreach (var stockdata in jsondecode)
            {
                Stock_GridView.Rows.Add(stockdata.Name, Set.Setget(name: stockdata.Name));
            }

            foreach (DataGridViewRow row in Stock_GridView.Rows)
            {
                row.Height = 50;
            }

            Stock_GridView.Visible = true;
            AddPanel.Visible = true;
            refresh.Start();
        }
        private async void timer1_Tick(object sender, EventArgs e)
        {
            if (ShareData.TimerStatus == "Start")
            {
                for (int i = 0;i < Stock_GridView.Rows.Count;i++)
                {
                    if (ShareData.debugmode)
                    {
                        Console.WriteLine($"{i} : {Stock_GridView.Rows.Count}");
                    }

                    //Stock_GridView.Rows[i].Cells["Price"].Value = Set.Setget(name: Stock_GridView.Rows[i].Cells["Name"].Value.ToString());
                    await Task.Run(() => Stock_GridView.Rows[i].Cells["Price"].Value = Set.Setget(name: Stock_GridView.Rows[i].Cells["Name"].Value.ToString()));
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Stock_GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Stock_GridView.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                if (ShareData.debugmode)
                {
                    Console.WriteLine(Stock_GridView.Rows[e.RowIndex].Cells["Name"].Value);
                }
                
                string command = $"SELECT Stock_list_data FROM stock_data WHERE BINARY Username='{ShareData.username}'";

                string[,] data = mysql.query(command);
                List<StockList> jsondecode = JsonConvert.DeserializeObject<List<StockList>>(data[0, 0]);

                string jsonencode = "[";

                int i = 0;
                foreach (var stockdata in jsondecode)
                {
                    if (stockdata.Name != Stock_GridView.Rows[e.RowIndex].Cells["Name"].Value.ToString() && i == 0)
                    {
                        jsonencode += "{\"Name\":\"" + $"{stockdata.Name}" + "\",\"Price\":\"0.00\"}";
                    }else if (stockdata.Name != Stock_GridView.Rows[e.RowIndex].Cells["Name"].Value.ToString() && i != 0)
                    {
                        jsonencode += ",{\"Name\":\"" + $"{stockdata.Name}" + "\",\"Price\":\"0.00\"}";
                    }
                    i++;
                }
                jsonencode += "]";

                command = $"UPDATE stock_data SET Stock_list_data='{jsonencode}' WHERE Username='{ShareData.username}'"; //{ShareData.username}
                mysql.query(command);
                Stock_GridView.Rows.RemoveAt(e.RowIndex);
            }
        }

        private async void add_Click(object sender, EventArgs e)
        {
            if (stockname.Text != string.Empty)
                foreach(DataGridViewRow stockdata in Stock_GridView.Rows)
                {
                   if (stockname.Text.ToUpper() == stockdata.Cells["Name"].Value.ToString())
                   {
                        DialogResult msevent = MessageBox.Show("Please check your stock name", "The stock name was added", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (msevent == DialogResult.OK)
                        {
                            stockname.Text = "";
                        }
                        return;
                    }
                }
                string price = Set.Setget(name: stockname.Text.ToUpper());
                if (price != null)
                {
                    Stock_GridView.Rows.Add(stockname.Text.ToUpper(), price);
                    Stock_GridView.Rows[Stock_GridView.Rows.Count - 1].Height = 50;
                }
                else
                {
                    DialogResult msevent = MessageBox.Show("Please check your stock name", "Can't find stock name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (msevent == DialogResult.OK)
                    {
                        stockname.Text = "";
                    }
                    return;
                }
                
                string command = $"SELECT Stock_list_data FROM stock_data WHERE BINARY Username='{ShareData.username}'";

                string[,] data = mysql.query(command);
                List<StockList> jsondecode = JsonConvert.DeserializeObject<List<StockList>>(data[0, 0]);

                string jsonencode = "[";
                
                foreach (var stockdata in jsondecode)
                {
                    jsonencode += "{\"Name\":\"" + $"{stockdata.Name}" + "\",\"Price\":\"0.00\"},";
                }
                jsonencode += "{\"Name\":\"" + $"{stockname.Text.ToUpper()}" + "\",\"Price\":\"0.00\"}]";

                command = $"UPDATE stock_data SET Stock_list_data='{jsonencode}' WHERE Username='{ShareData.username}'"; //{ShareData.username}
                mysql.query(command);
                stockname.Text = "";
        }

        private void AddPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
