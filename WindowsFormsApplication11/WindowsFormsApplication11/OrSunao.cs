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
    public partial class OrSunao : Form
    {
        public OrSunao()
        {
            InitializeComponent();
        }

        private void registeradmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            RegisterAdmin r1 = new RegisterAdmin();
            r1.Show();
            this.Close();
        }

        private void loginadmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginAdmin a1 = new LoginAdmin();
            a1.Show();
            this.Show();
            this.Close();
        }
    }
}
