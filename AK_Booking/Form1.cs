using AxSHDocVw;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AK_Booking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWebBrowser1.Navigate("https://mobileticket.interpark.com/goods/20003504");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWebBrowser1.Navigate("https://interpark.com/");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWebBrowser1.Navigate("https://interpark.com/goods/20003504");
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void axWebBrowser1_DocumentComplete(object sender, AxSHDocVw.DWebBrowserEvents2_DocumentCompleteEvent e)
        {
            AxWebBrowser axWeb = (AxWebBrowser)sender;
            if (axWeb == null) return;
            mshtml.IHTMLDocument2 doc = (mshtml.IHTMLDocument2)axWeb.Document;
            mshtml.IHTMLElementCollection HEC = (mshtml.IHTMLElementCollection)doc.all;

            foreach (mshtml.IHTMLElement elements in HEC)
            {
                if (elements.innerHTML != null && elements.innerHTML.Contains("책가방 담기"))
                {
                    if (elements.tagName.Equals("A")/* && elements.id.ToStringEx() == "btn_bag_1"*/)
                    {
                        elements.click();
                        return;
                    }
                }
            }
        }
    }
}
