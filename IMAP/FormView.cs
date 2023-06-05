using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic.ApplicationServices;

namespace IMAP
{
    public partial class FormView : Form
    {
        string from, to, sub, html;
        public FormView(string from, string to,string sub, string html)
        {
            InitializeComponent();
            this.from = from;
            this.to = to;
            this.html = html;
            this.sub = sub;
        }


        private async void FormView_Load(object sender, EventArgs e)
        {
            tbFrom.Text = from;
            tbTo.Text = to;
            tbSub.Text = sub;
            tbFrom.Enabled = false;
            tbTo.Enabled = false;
            tbSub.Enabled = false;

            await webView21.EnsureCoreWebView2Async();
            webView21.NavigateToString(html);
        }

        private void btReply_Click(object sender, EventArgs e)
        {

        }
    }
}
