using System;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using HtmlAgilityPack;
using MySqlX.XDevAPI;

namespace MyProject
{
    class Set
    {

        public static string Setget(string name = "")
        {
            string url = $"https://www.set.or.th/th/market/product/stock/quote/{name}/price";
            WebClient client = new WebClient();
            string htmlContent = client.DownloadString(url);
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(htmlContent);
            HtmlNodeCollection nodes = doc.DocumentNode.SelectNodes("//*/h1[@class='value text-white mb-0 me-2 lh-1']");
            if (nodes !=  null)
            {
                if (ShareData.debugmode)
                {
                    Console.WriteLine($"{name} : {nodes[0].InnerHtml.ToString().Trim()}");
                }
                return nodes[0].InnerHtml.ToString().Trim();
                /*foreach (HtmlNode node in nodes)
                {
                    Console.WriteLine(node.InnerHtml.Trim());
                }*/

            }

            return null;
            //return $"{name} : {nodes[0].InnerHtml.ToString().Trim()}";
        }
    }
}
