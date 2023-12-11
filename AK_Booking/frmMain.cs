using AxSHDocVw;
using BH_Library.Utils;
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
    public partial class frmMain : Form
    { 
        public frmMain()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
        }

        private void SetBrower(List<string> lstUrl)
        {

        }

        private void btnRefreshAll_Click(object sender, EventArgs e)
        {
            List<UrlModel> ListUrl = new List<UrlModel>();
            axWebBrowser1.Navigate("http://culture.akplaza.com/cult/lecture.do?method=view&number=01&menu_num=2_1&hq=00&store=01&period=100&sSubject_cd=205062&sGubn=1&sMain_cd=2&sSect_cd=05&sSect_nm=1%C0%CF%20%B0%F8%B0%B3%B0%AD%C1%C2&expired=F");
            axWebBrowser2.Navigate("http://culture.akplaza.com/cult/lecture.do?method=view&number=01&menu_num=2_1&hq=00&store=01&period=100&sSubject_cd=205006&sGubn=1&sMain_cd=2&sSect_cd=05&sSect_nm=1%C0%CF%20%B0%F8%B0%B3%B0%AD%C1%C2&expired=F");
            axWebBrowser3.Navigate("http://culture.akplaza.com/cult/lecture.do?method=view&number=01&menu_num=2_1&hq=00&store=01&period=100&sSubject_cd=205069&sGubn=1&sMain_cd=2&sSect_cd=05&sSect_nm=1%C0%CF%20%B0%F8%B0%B3%B0%AD%C1%C2&expired=F");
            axWebBrowser4.Navigate("http://culture.akplaza.com/cult/lecture.do?method=view&number=01&menu_num=2_1&hq=00&store=01&period=100&sSubject_cd=205010&sGubn=1&sMain_cd=2&sSect_cd=05&sSect_nm=1%C0%CF%20%B0%F8%B0%B3%B0%AD%C1%C2&expired=F");
            axWebBrowser5.Navigate("http://culture.akplaza.com/cult/lecture.do?method=view&number=01&menu_num=2_1&hq=00&store=01&period=100&sSubject_cd=205013&sGubn=1&sMain_cd=2&sSect_cd=05&sSect_nm=1%C0%CF%20%B0%F8%B0%B3%B0%AD%C1%C2&expired=F");
            axWebBrowser6.Navigate("http://culture.akplaza.com/cult/lecture.do?method=view&number=01&menu_num=2_1&hq=00&store=01&period=100&sSubject_cd=205017&sGubn=1&sMain_cd=2&sSect_cd=05&sSect_nm=1%C0%CF%20%B0%F8%B0%B3%B0%AD%C1%C2&expired=F");
            axWebBrowser7.Navigate("http://culture.akplaza.com/cult/lecture.do?method=view&number=01&menu_num=2_1&hq=00&store=01&period=100&sSubject_cd=205025&sGubn=1&sMain_cd=2&sSect_cd=05&sSect_nm=1%C0%CF%20%B0%F8%B0%B3%B0%AD%C1%C2&expired=F");
            axWebBrowser8.Navigate("http://culture.akplaza.com/cult/lecture.do?method=view&number=01&menu_num=2_1&hq=00&store=01&period=100&sSubject_cd=205031&sGubn=1&sMain_cd=2&sSect_cd=05&sSect_nm=1%C0%CF%20%B0%F8%B0%B3%B0%AD%C1%C2&expired=F");
            axWebBrowser9.Navigate("http://culture.akplaza.com/cult/lecture.do?method=view&number=01&menu_num=2_1&hq=00&store=01&period=100&sSubject_cd=205036&sGubn=1&sMain_cd=2&sSect_cd=05&sSect_nm=1%C0%CF%20%B0%F8%B0%B3%B0%AD%C1%C2&expired=F");
            axWebBrowser10.Navigate("http://culture.akplaza.com/cult/lecture.do?method=view&number=01&menu_num=2_1&hq=00&store=01&period=100&sSubject_cd=205043&sGubn=1&sMain_cd=2&sSect_cd=05&sSect_nm=1%C0%CF%20%B0%F8%B0%B3%B0%AD%C1%C2&expired=F");
            axWebBrowser11.Navigate("http://culture.akplaza.com/cult/lecture.do?method=view&number=01&menu_num=2_1&hq=00&store=01&period=100&sSubject_cd=205048&sGubn=1&sMain_cd=2&sSect_cd=05&sSect_nm=1%C0%CF%20%B0%F8%B0%B3%B0%AD%C1%C2&expired=F");
            axWebBrowser12.Navigate("http://culture.akplaza.com/cult/lecture.do?method=view&number=01&menu_num=2_1&hq=00&store=01&period=100&sSubject_cd=205063&sGubn=1&sMain_cd=2&sSect_cd=05&sSect_nm=1%C0%CF%20%B0%F8%B0%B3%B0%AD%C1%C2&expired=F");
            axWebBrowser13.Navigate("http://culture.akplaza.com/cult/lecture.do?method=view&number=01&menu_num=2_1&hq=00&store=01&period=100&sSubject_cd=202021&sGubn=1&sMain_cd=2&sSect_cd=02&sSect_nm=%BD%C5%C3%BC%C8%B0%B5%BF%20%C5%EB%C7%D5%B3%EE%C0%CC&expired=F");
            axWebBrowser14.Navigate("http://culture.akplaza.com/cult/lecture.do?method=view&number=01&menu_num=2_1&hq=00&store=01&period=100&sSubject_cd=205051&sGubn=1&sMain_cd=2&sSect_cd=05&sSect_nm=1%C0%CF%20%B0%F8%B0%B3%B0%AD%C1%C2&expired=F");
            axWebBrowser15.Navigate("http://culture.akplaza.com/cult/lecture.do?method=view&number=01&menu_num=2_1&hq=00&store=01&period=100&sSubject_cd=205052&sGubn=1&sMain_cd=2&sSect_cd=05&sSect_nm=1%C0%CF%20%B0%F8%B0%B3%B0%AD%C1%C2&expired=F");
            axWebBrowser16.Navigate("http://culture.akplaza.com/cult/lecture.do?method=view&number=01&menu_num=2_1&hq=00&store=01&period=100&sSubject_cd=205054&sGubn=1&sMain_cd=2&sSect_cd=05&sSect_nm=1%C0%CF%20%B0%F8%B0%B3%B0%AD%C1%C2&expired=F");
            axWebBrowser17.Navigate("http://culture.akplaza.com/cult/lecture.do?method=view&number=01&menu_num=2_1&hq=00&store=01&period=100&sSubject_cd=205056&sGubn=1&sMain_cd=2&sSect_cd=05&sSect_nm=1%C0%CF%20%B0%F8%B0%B3%B0%AD%C1%C2&expired=F");
            axWebBrowser18.Navigate("http://culture.akplaza.com/cult/lecture.do?method=view&number=01&menu_num=2_1&hq=00&store=01&period=100&sSubject_cd=205057&sGubn=1&sMain_cd=2&sSect_cd=05&sSect_nm=1%C0%CF%20%B0%F8%B0%B3%B0%AD%C1%C2&expired=F");
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            axWebBrowser19.Navigate("http://culture.akplaza.com/");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "미탐지")
                label1.Text = "탐지";
            else
                label1.Text = "미탐지";
        }

        private void axWebBrowser_DocumentComplete(object sender, AxSHDocVw.DWebBrowserEvents2_DocumentCompleteEvent e)
        {
            if (label1.Text == "미탐지") return;
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

        private void button2_Click(object sender, EventArgs e)
        {
            //axWebBrowser19.Navigate("http://culture.akplaza.com/cult/lecture.do?method=view&number=01&menu_num=2_1&hq=00&store=01&period=100&sSubject_cd=205057&sGubn=1&sMain_cd=2&sSect_cd=05&sSect_nm=1%C0%CF%20%B0%F8%B0%B3%B0%AD%C1%C2&expired=F");
        }
    }
}
