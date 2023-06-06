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
using System.Xml.Linq;
using MailKit.Net.Imap;
using MailKit.Net.Smtp;
using System.IO;

namespace IMAP
{
    public partial class FormSend : Form
    {

        string email, pass, path;

        public FormSend(string email, string pass)
        {
            InitializeComponent();
            this.email = email;
            this.pass = pass;
            tbFrom.Text = email;
            tbFrom.Enabled = false;
        }

        BodyBuilder builder = new BodyBuilder();

        private void btSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            path = ofd.FileName;
            tbPath.Text = path;
            builder.Attachments.Add(path);
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new SmtpClient();
                client.Connect("smtp.gmail.com",465, true); // smtp host, port, use ssl.
                client.Authenticate(email, pass); // gmail account, app password
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress(tbName.Text, email));
                message.To.Add(new MailboxAddress("", tbTo.Text));
                message.Subject = tbSub.Text;
                builder.TextBody = rtbBody.Text;
                message.Body = builder.ToMessageBody();
                client.Send(message);
                MessageBox.Show("Thành công! Đã gửi mail");
            }
            catch
            {
                MessageBox.Show("Lỗi! Không gửi được mail");
            }
        }
    }
}
