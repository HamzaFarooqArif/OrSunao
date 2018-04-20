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
    public partial class LoginUser : Form
    {
        public LoginUser()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Server.Service1 server = new Server.Service1();
            bool islogin;
            bool ispassed;
            server.SLoginUser(txt_Email.Text, txt_Password.Text, out islogin, out ispassed);
            if(ispassed)
            {
                if(islogin)
                {
                    MessageBox.Show("You are Successfully entered Or Sunao :'D !");
                }
                else
                {
                    MessageBox.Show("You cant log in because u are not a member of Or sunao");
                }
            }
            txt_Email.Clear();
            txt_Password.Clear();
        }

        private void lnklbl_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterUser r = new RegisterUser();
            r.Show();
            this.Close();
        }

        private void lnklbl_GoToMainPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OrSunao s = new OrSunao();
            s.Show();
            this.Close();
        }
    }
}
