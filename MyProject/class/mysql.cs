using System;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Management;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace MyProject
{
    class mysql
    {
        public static string server = "127.0.0.1";
        private static string database = "myproject";
        private static string uid = "root";
        private static string password = "";
        private static string connectstring = "SERVER=" + server
                                   + ";DATABASE=" + database
                                   + ";UID=" + uid
                                   + ";PASSWORD=" + password;
        private static MySqlConnection conn = new MySqlConnection(connectstring);

        public mysql()
        {

        }

        public static string Connection()
        {
            string result = "";
            if (ShareData.TimerStatus == "Start")
            {
                if (mysql.server_available() == true)
                {
                    result = "Server status : Connected";
                }
                else
                {
                    result = "Server status : Disconnected";
                }

            Retry:
                string command = $"SELECT NOW()";
                string[,] data = mysql.query(command);
                DateTime now = DateTime.Now;
                TimeSpan timediff = DateTime.Parse(data[0, 0]) - now;
                if (ShareData.debugmode)
                {
                    Console.WriteLine(timediff);
                }
                if (timediff > TimeSpan.FromMinutes(5))
                {
                    DialogResult msevent = MessageBox.Show("Please check your time is current", "Time Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (msevent == DialogResult.Retry)
                    {
                        goto Retry;
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }
            return result;
        }
        public static bool server_available()
        {
            try
            {
                try
                {
                    conn.Open();
                    if (ShareData.debugmode)
                        Console.WriteLine("database connected");
                    conn.Close();
                    return true;
                }catch
                {
                    conn.Close();
                    conn.Open();
                    if (ShareData.debugmode)
                        Console.WriteLine("database connected");
                    conn.Close();
                    return true;
                }
                
            }
            catch
            {
                if (ShareData.debugmode)
                    Console.WriteLine("database connect error");
                return false;
            }
        }

        public static dynamic query(string command)
        {
            ReQuery:
            try
            {
                conn.Open();
                MySqlCommand qry = new MySqlCommand(command, conn);
                if (command.Contains("INSERT") || command.Contains("UPDATE") || command.Contains("DELETE"))
                {
                    if (command.Contains("UPDATE"))
                    {
                        if (ShareData.debugmode)
                            Console.WriteLine("Start update");
                        if (qry.ExecuteNonQuery() > 0)
                        {
                            if (ShareData.debugmode)
                            {
                                Console.WriteLine("UPDATE Success!!!");
                            }
                        }else
                        {
                            if (ShareData.debugmode)
                            {
                                Console.WriteLine("UPDATE Fail!!!");
                            }
                        }
                    }
                    //qry.ExecuteNonQuery();
                }
                else
                {
                    MySqlDataReader data_reader = qry.ExecuteReader();
                    int row = 0, col = data_reader.FieldCount;
                    string[,] data = new string[10000, 10000];
                    while (data_reader.Read())
                    {
                        for (int i = 0; i < data_reader.FieldCount; i++)
                        {
                            data[row, i] = data_reader[i].ToString();
                        }
                        row++;
                    }

                    if (ShareData.debugmode)
                        Console.WriteLine("[" + row.ToString() + ":" + col.ToString() + "]");
                    string[,] resized_data = new string[row, col];
                    for (int i = 0; i < row; i++)
                    {
                        if (ShareData.debugmode)
                            Console.Write("[" + row.ToString() + "] ");
                        for (int j = 0; j < col; j++)
                        {
                            if (j == 0 && col == 1)
                            {
                                if (ShareData.debugmode)
                                    Console.WriteLine("[ " + data[i, j] + " ]");
                            }
                            else if (j == 0)
                            {
                                if (ShareData.debugmode)
                                    Console.Write("[ " + data[i, j] + " , ");
                            }
                            else if (j >= col - 1)
                            {
                                if (ShareData.debugmode)
                                    Console.WriteLine(data[i, j] + " ]");
                            }
                            else
                            {
                                if (ShareData.debugmode)
                                    Console.Write(data[i, j] + " , ");
                            }

                            resized_data[i, j] = data[i, j];
                        }
                    }

                    data_reader.Close();
                    conn.Close();
                    return resized_data;
                }
            }catch
            {
                Retry:
                if (!mysql.server_available() && ShareData.TimerStatus == "Start")
                {
                    ShareData.TimerStatus = "Stop";
                    DialogResult msevent = MessageBox.Show("Server is not connected", "Connectin Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (msevent == DialogResult.Retry)
                    {
                        goto Retry;
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                ShareData.TimerStatus = "Start";
                goto ReQuery;
            }
            return null;
        }
    }
}