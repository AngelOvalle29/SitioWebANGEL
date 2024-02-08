using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SitioWebANGEL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Resize += new System.EventHandler(this.Form_Resize);
            
        }
       
        private void Form_Resize(object sender, EventArgs e)
        {
            webView21.Size = this.ClientSize - new System.Drawing.Size(webView21.Location);
            button1.Left = this.ClientSize.Width - button1.Width;
            comboBox1.Width = button1.Left - comboBox1.Left;
        }


        private void hToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //webBrowser1.GoBack();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string link="";
            if (!(comboBox1.Text.Contains(".")))
            {
                link = "https://www.google.com/search?q="+comboBox1.Text;
            }
            if (webView21 != null && webView21.CoreWebView2 != null)
            {
                webView21.CoreWebView2.Navigate(link);
            }
            
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //webBrowser1.GoHome();
        }

        private void haciaAdelanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //webBrowser1.GoForward();
        }

        private void escribaAquíToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            //webBrowser1.GoHome();
        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }
    }
}
