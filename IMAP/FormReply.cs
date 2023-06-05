using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace IMAP
{
    public partial class FormReply : Form
    {
        string from, to, pass, sub;

        public FormReply(string from, string to, string pass, string sub)
        {
            InitializeComponent();
            this.from = from;
            this.to = to;
            this.pass = pass;
            this.sub = sub;
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            //try
            //{
                var client = new SmtpClient();
                client.Connect("smtp.gmail.com", 465, true); // smtp host, port, use ssl.
                client.Authenticate(from, pass); // gmail account, app password
                var reply = new MimeMessage();
                reply.From.Add(new MailboxAddress(tbName.Text, from));
                reply.To.Add(new MailboxAddress("", tbTo.Text));
                reply.Subject = tbSub.Text;
                reply.Body = new TextPart("plain")
                {
                    Text = rtbBody.Text
                };
                client.Send(reply);
                MessageBox.Show("Thành công! Đã gửi mail");
            //}
            //catch
            //{
            //    MessageBox.Show("Lỗi! Không gửi được mail");
            //}
        }

        private void FormReply_Load(object sender, EventArgs e)
        {
            tbFrom.Text = from;
            tbTo.Text = to;
            tbSub.Text = "Re: " + sub;
            tbFrom.Enabled = false;
            tbTo.Enabled = false;
        }
    }
}
