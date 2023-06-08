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
        string gmail, pass;
        int page = 0, tolpage;

        public MainForm(string gmail, string pass)
        {
            InitializeComponent();
            this.gmail = gmail;
            this.pass = pass;
            tbOwn.Text = gmail;
            tbOwn.Enabled = false;
        }

        void LoadF(int page)
        {
            lvBox.Items.Clear();
            MessageBox.Show("Đang load mail, vui lòng chờ trong giây lát!");
            try
            {
                var client = new ImapClient();
                client.Connect("imap.gmail.com", 993, true); // imap host, port, use ssl.
                client.Authenticate(gmail, pass); // gmail accout, app password.
                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);

                lbTotal.Text = "Total: " + inbox.Count.ToString();

                if (inbox.Count % 20 > 0) tolpage = inbox.Count / 20 + 1;
                else tolpage = inbox.Count % 20;

                int limit = 1 + 20 * page;
                for (int i = inbox.Count - 1 - (page * 20); i >= 0; i--)
                {
                    var message = inbox.GetMessage(i);
                    ListViewItem item = new ListViewItem(limit.ToString());
                    item.SubItems.Add(message.From.ToString());
                    item.SubItems.Add(message.Subject.ToString());
                    item.SubItems.Add(message.Date.ToString());
                    lvBox.Items.Add(item);
                    if (limit % 20 == 0)
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
                MessageBox.Show("Sai tài khoản, vui lòng nhập lại");
                this.Close();
            }
        }

        private void MainForm_Load(object sender, EventArgs e) // dùng để hiển thị danh sách 50 thư mới nhất của gmail
        {
            LoadF(page);
            tbPage.Text = (page + 1).ToString();
            lbpage.Text = "1 - 20";
        }

        private void btSendM_Click(object sender, EventArgs e) // hiển thị form FormSenđ
        {
            FormSend formSend = new FormSend(gmail, pass);
            formSend.Show();
        }

        private void btRef_Click(object sender, EventArgs e) //dùng để load lại danh sách 50 thư mới nhất của gmail
        {
            page = 0;
            lbpage.Text = (page * 20 + 1).ToString() + " - " + (page * 20 + 20).ToString();
            tbPage.Text = (page + 1).ToString();
            LoadF(page);
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            if (page > 0)
            {
                page--;
                lbpage.Text = (page * 20 + 1).ToString() + " - " + (page * 20 + 20).ToString();
                tbPage.Text = (page + 1).ToString();
                LoadF(page);
            }
            else
            {
                MessageBox.Show("Không thể back!");
            }
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            if (page < tolpage)
            {
                page++;
                lbpage.Text = (page * 20 + 1).ToString() + " - " + (page * 20 + 20).ToString();
                tbPage.Text = (page + 1).ToString();
                LoadF(page);
            }
            else
            {
                MessageBox.Show("Không thể next!");
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
            client.Authenticate(gmail, pass); // gmail accout, app password.
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
