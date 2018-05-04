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
    public partial class chatbox : Form
    {
        public static chatbox chatboxform = null;
        public chatbox()
        {
            InitializeComponent();
        }
        public void setmyname(string m)
        {
            lbl_me.Text = m;
        }
        public void sethisname(string m)
        {
            lbl_connecteduser.Text = m; 
        }
        private void chatbox_Load(object sender, EventArgs e)
        {
            chatbox.chatboxform = this;
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            Server.Service1 server = new Server.Service1();
            bool ispassed, passed;
            server.SIsOfflineUser(lbl_connecteduser.Text, out passed, out ispassed);
            if(ispassed)
            {
                if(passed)
                {
                    MessageBox.Show("oops your friend has gone ! talk to u later :'D");
                    EnterUser.EnterUserForm.Show();
                    this.Hide();
                }
                else
                {
                     msg n = new msg(txt_message.Text);
                    flowLayoutPanel1.Controls.Add(n);
                    txt_message.Clear();
                }
            }
           
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
           
            EnterUser.EnterUserForm.Show();
            this.Hide();
        }
    }
}
