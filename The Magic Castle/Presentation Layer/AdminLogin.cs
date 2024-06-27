using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_Magic_Castle.DataAccess_layer;

namespace The_Magic_Castle.Presentation_Layer
{
    public partial class AdminLogin : Form
    {
        public static AdminLogin adminLogin { get; internal set; }

        public AdminLogin()
        {
            InitializeComponent();
        }

        private void AdminLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (adminnameTextBox.Text == "")
            {
                MessageBox.Show("Username cannot be empty");
            }
            else if (adminpassTextBox.Text == "")
            {
                MessageBox.Show("Password cannot be empty");
            }
            else
            {
                AdminDataAccess userDataAccess = new AdminDataAccess();
                if (userDataAccess.LoginValidation(adminnameTextBox.Text, adminpassTextBox.Text))
                {
                    AdminHome adminhome = new AdminHome();
                    adminhome.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
