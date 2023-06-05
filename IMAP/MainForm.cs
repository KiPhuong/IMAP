using MailKit.Net.Imap;
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
        
        private void MainForm_Load(object sender, EventArgs e)
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

        private void btSendM_Click(object sender, EventArgs e)
        {
            FormSend formSend = new FormSend(email, pass);
            formSend.Show();
        }

        private void btRef_Click(object sender, EventArgs e)
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

        private void lvBox_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btLogout_Click(object sender, EventArgs e)
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
