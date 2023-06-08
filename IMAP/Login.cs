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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e) // hiển thị form Login
        {
            MainForm mainForm = new MainForm(tbgmail.Text, tbPass.Text);
            mainForm.ShowDialog();
            
        }
    }
}
