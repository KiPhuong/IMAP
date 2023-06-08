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

        string gmail, pass, path;

        public FormSend(string gmail, string pass)
        {
            InitializeComponent();
            this.gmail = gmail;
            this.pass = pass;
            tbFrom.Text = gmail;
            tbFrom.Enabled = false;
        }

        
        BodyBuilder builder = new BodyBuilder();
        private void btSelect_Click(object sender, EventArgs e) // chọn file được đính kèm khi gửi mail
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            path = ofd.FileName;
            string temp = Path.GetFileName(path);
            tbPath.Text += temp + "  ";
            builder.Attachments.Add(path);
        }

        private void btSend_Click(object sender, EventArgs e) // hàm dùng để gửi mail
        {
            try
            {
                var client = new SmtpClient();
                client.Connect("smtp.gmail.com",465, true); // smtp host, port, use ssl.
                client.Authenticate(gmail, pass); // gmail account, app password
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress(tbName.Text, gmail));
                message.To.Add(new MailboxAddress("", tbTo.Text));
                message.Subject = tbSub.Text;
                builder.TextBody = rtbBody.Text;
                message.Body = builder.ToMessageBody();
                client.Send(message);
                MessageBox.Show("Thành công! Đã gửi mail");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Lỗi! Không gửi được mail");
            }
        }
    }
}
