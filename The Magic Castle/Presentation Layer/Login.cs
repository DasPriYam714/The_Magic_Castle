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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (usernameTextBox.Text == "")
                {
                    MessageBox.Show("Username cannot be empty");
                }
                else if (passwordTextBox.Text == "")
                {
                    MessageBox.Show("Password cannot be empty");
                }
                else
                {
                    UserDataAccess userDataAccess = new UserDataAccess();
                    if (userDataAccess.LoginValidation(usernameTextBox.Text, passwordTextBox.Text))
                    {
                        Login_Dashboard logindashboard = new Login_Dashboard();
                        logindashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password");
                    }


                }
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        

        private void newRagistrationLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
                Registration Registration = new Registration();
                Registration.Show();

                this.Hide();
            }

        private void adminButton_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            TMC_Homepage tMC_Homepage = new TMC_Homepage();
            tMC_Homepage.Show();
            this.Hide();
        }
    }
    }

