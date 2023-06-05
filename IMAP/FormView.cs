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

namespace IMAP
{
    public partial class FormView : Form
    {
        string from, to, body;
        public FormView(string from, string to, string body)
        {
            InitializeComponent();
            this.from = from;
            this.to = to;
            this.body = body;
        }

        private void FormView_Load(object sender, EventArgs e)
        {
            tbFrom.Text = from;
            tbTo.Text = to;
            tbFrom.Enabled = false;
            tbTo.Enabled = false;
            rtbBody.Text = body;
            //webView21.NavigateToString(html);
        }

        private void btReply_Click(object sender, EventArgs e)
        {

        }
    }
}
