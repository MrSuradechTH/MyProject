using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject
{

    //GlobalShare Normal Data
    class ShareData
    {
        public static string username = "";
        public static string password = "";
        public static string TimerStatus = "Start";
        public static bool debugmode = true;

        public static string server_status = "";
    }


    //Stock_List
    public class StockList
    {
        public string Name { get; set; }
        public string Price { get; set; }
    }
}
