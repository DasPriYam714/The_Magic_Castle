using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Magic_Castle.Presentation_Layer
{
    public partial class TMC_Homepage : Form
    {
        public TMC_Homepage()
        {
            InitializeComponent();
        }

        private void TMC_Homepage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();

        }

        private void contuctButton_Click(object sender, EventArgs e)
        {
            Contuct_Us contuct_Us = new Contuct_Us();
            contuct_Us.Show();
            this.Hide();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            About_Us about_Us = new About_Us();
            about_Us.Show();
            this.Hide();
        }
    }
}
