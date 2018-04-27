using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    public partial class EnterUser : Form
    {
        public EnterUser()
        {
            InitializeComponent();
        }
        public void setname(string name)
        {
            lbl_name.Text = name;
        }

        private void EnterUser_Load(object sender, EventArgs e)
        {
            List<string> strnamer = new List<string>();
            Server.Service1 server = new Server.Service1();
            string[] strnamer1 = strnamer.ToArray();
            server.getUsersContacts(lbl_name.Text, ref strnamer1);
            int idx = 0;
            foreach (string s in strnamer1)
            {
                UserControl4 uc = new UserControl4(s);
                flowLayoutPanel1.Controls.Add(uc);
                idx++;

            }
        }

        private void lbl_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginUser l = new LoginUser();
            l.Show();
            this.Hide();
        }
    }
}
