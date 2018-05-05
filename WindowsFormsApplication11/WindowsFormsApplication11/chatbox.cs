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
        //----------------------------------------------------------------
        private void chatbox_Load(object sender, EventArgs e)
        {
            chatbox.chatboxform = this;
            

            Timer timer = new Timer();
            timer.Interval = (1 * 1000); // 10 secs
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            string message = "";
            Server.Service1 server = new Server.Service1();
            server.setConnected(lbl_me.Text, true, true);
            server.getChatText(lbl_me.Text, ref message);
            if (!(message == ""))
            {
                msg n = new msg(message);
                flowLayoutPanel1.Controls.Add(n);
                server.setChatToEmpty(lbl_me.Text);
            }
        }
        //----------------------------------------------------------------

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
                    bool isHeConnected = false;
                    bool isHeConnectedPassed = false;
                    server.isConnected(lbl_connecteduser.Text, ref isHeConnected, ref isHeConnectedPassed);
                    if(isHeConnected)
                    {
                        server.setChatToText(lbl_connecteduser.Text, txt_message.Text);
                    }
                    else
                    {
                        MessageBox.Show("User not connected");
                    }
                    
                    /*msg n = new msg(txt_message.Text);
                    flowLayoutPanel1.Controls.Add(n);*/
                    txt_message.Clear();

                    
                }
            }
           
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
           
            EnterUser.EnterUserForm.Show();
            this.Hide();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            
        }
    }
}
