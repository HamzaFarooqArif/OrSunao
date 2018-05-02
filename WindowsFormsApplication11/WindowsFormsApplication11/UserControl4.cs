using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    public partial class UserControl4 : UserControl
    {
        private string email;
        private string password;
        public UserControl4()
        {
            InitializeComponent();
        }

        public UserControl4(string email)
        {
            InitializeComponent();
            lbl_Email.Text = email;
        }

        private void UserControl4_Load(object sender, EventArgs e)
        {

        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            /*Server.Service1 server = new Server.Service1();
            
            server.AddToContacts()*/
            
            MessageBox.Show("You are connect now!");
        }

        private void btn_Block_Click(object sender, EventArgs e)
        {
            EnterUser.EnterUserForm.refreshComponents();
            Server.Service1 server = new Server.Service1();
            server.AddToBlockedUsers(EnterUser.EnterUserForm.email, lbl_Email.Text);
        }
    }
}
