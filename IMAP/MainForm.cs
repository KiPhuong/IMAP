﻿using MailKit.Net.Imap;
using MailKit;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace IMAP
{
    public partial class MainForm : Form
    {
        string email, pass;

        public MainForm(string email, string pass)
        {
            InitializeComponent();
            this.email = email;
            this.pass = pass;
            tbOwn.Text = email;
            tbOwn.Enabled = false;
        }
        
        private void MainForm_Load(object sender, EventArgs e) // dùng để hiển thị danh sách 50 thư mới nhất của email
        { 
            try
            {

                var client = new ImapClient();
                client.Connect("imap.gmail.com", 993, true); // imap host, port, use ssl.
                client.Authenticate(email, pass); // gmail accout, app password.
                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);

                int limit = 1;

                for (int i = inbox.Count - 1; i >= 0; i--)
                {

                    var message = inbox.GetMessage(i);
                    ListViewItem item = new ListViewItem(limit.ToString());
                    item.SubItems.Add(message.From.ToString());
                    item.SubItems.Add(message.Subject.ToString());
                    item.SubItems.Add(message.Date.ToString());
                    lvBox.Items.Add(item);
                    if (limit == 50)
                    {
                        break;
                    }
                    else
                    {
                        limit++;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Sai tài khoản, vui lòng nhập lại: ");
                this.Close();
            }
            

        }

        private void btSendM_Click(object sender, EventArgs e) // hiển thị form FormSenđ
        {
            FormSend formSend = new FormSend(email, pass);
            formSend.Show();
        }

        private void btRef_Click(object sender, EventArgs e) //dùng để load lại danh sách 50 thư mới nhất của email
        {
            lvBox.Items.Clear();
            var client = new ImapClient();
            client.Connect("imap.gmail.com", 993, true); // imap host, port, use ssl.
            client.Authenticate(email, pass); // gmail accout, app password.
            var inbox = client.Inbox;
            inbox.Open(FolderAccess.ReadOnly);
            int limit = 1;
            for (int i = inbox.Count - 1; i >= 0; i--)
            {
                var message = inbox.GetMessage(i);
                ListViewItem item = new ListViewItem(limit.ToString());
                item.SubItems.Add(message.From.ToString());
                item.SubItems.Add(message.Subject.ToString());
                item.SubItems.Add(message.Date.ToString());
                lvBox.Items.Add(item);
                if (limit == 50)
                {
                    break;
                }
                else
                {
                    limit++;
                }

            }
        }

        // dùng để lấy số thứ tự của mail trong danh sách sau đó hiển thị nội dung thư đó lên FormView
        private void lvBox_SelectedIndexChanged(object sender, EventArgs e)     
        {

            if (lvBox.SelectedItems.Count == 0) return;
            ListViewItem item = lvBox.SelectedItems[0];
            int num = Int32.Parse(item.SubItems[0].Text);
            var client = new ImapClient();
            client.Connect("imap.gmail.com", 993, true); // imap host, port, use ssl.
            client.Authenticate(email, pass); // gmail accout, app password.
            var inbox = client.Inbox;
            inbox.Open(FolderAccess.ReadOnly);
            var message = inbox.GetMessage(inbox.Count - num);
            FormView formView = new FormView(message.From.ToString(), message.To.ToString(),message.Subject.ToString(), message.HtmlBody.ToString(), pass);
            formView.Show();
        }

        private void btLogout_Click(object sender, EventArgs e) //dùng để log out 
        {
            DialogResult logout = MessageBox.Show("Bạn có chắc muốn log out?", "Log out", MessageBoxButtons.YesNo);
            if (logout == DialogResult.Yes)
            {
                this.Close();
            }
            else if (logout == DialogResult.No)
            {
                
            }
        }
    }
}
