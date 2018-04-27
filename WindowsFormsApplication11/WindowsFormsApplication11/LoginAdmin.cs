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
    public partial class LoginAdmin : Form
    {
        public LoginAdmin()
        {
            InitializeComponent();
        }

        private void lnklbl_SignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterAdmin r = new RegisterAdmin();
            r.Show();
            this.Close();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Server.Service1 server = new Server.Service1();
            EnterAdmin p = new EnterAdmin();
            bool islogin;
            bool ispassed;
            server.SLoginAdmin(txt_Email.Text, txt_Password.Text, out islogin, out ispassed);
            if (ispassed)
            {
                if(islogin)
                {
                   
                    p.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("You cant take the seat of Admin now!");
                }
            }
            txt_Password.Clear();
            txt_Email.Clear();

        }

        private void lnklbl_GoToMainPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OrSunao o = new OrSunao();
            o.Show();
            this.Close();
        }
    }
}
