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
using The_Magic_Castle.Entity_classes;

namespace The_Magic_Castle.Presentation_Layer
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            confirmButton.Enabled = false;
        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void termCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(termCheckBox.Checked)
            {
                confirmButton.Enabled = true;
            }
            else
            {
                confirmButton.Enabled = false;
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if(nameTextBox.Text=="")
            {
                MessageBox.Show("Name cannot be empty.");
            }
            else if(usernameTextBox.Text=="")
            {
                MessageBox.Show("Username cannot be empty.");
            }
            else if (emailTextBox.Text == "")
            {
                MessageBox.Show("Email cannot be empty.");
            }
            else if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Password cannot be empty.");
            }
            else if (confirmPasswordTextBox.Text=="")
            {
                MessageBox.Show("Confirm password cannot be empty.");
            }
           else if(dobDateTimePicker.Value.Date.ToString()== DateTime.Now.Date.ToString())
            {
                MessageBox.Show("Date of birth cannot be empty.");
            }
            else if(bloodGroupComboBox.Text=="")
            {
                MessageBox.Show("Select blood group.");
            }
            else
            {
                if(passwordTextBox.Text!=confirmPasswordTextBox.Text)
                {
                    MessageBox.Show("Password and Confirm password doesn't match.");
                }
                else
                {
                    User user = new User();
                    user.Name = nameTextBox.Text;
                    user.Username = usernameTextBox.Text;
                    user.Email = emailTextBox.Text;
                    user.Password = passwordTextBox.Text;
                    user.DateOfBirth = dobDateTimePicker.Text;
                    
                    user.BloodGroup = bloodGroupComboBox.Text;

                    //string sql = "INSERT INTO Users(Name,Username,Email,Password,DateOfBirth,Gender,BloodGroup) VALUES('"+user.Name+"','"+user.Username+"','"+user.Email+"','"+user.Password+"','"+user.DateOfBirth+"','"+user.Gender+"','"+user.BloodGroup+"')";
                    //SqlCommand command = new SqlCommand(sql, connection);
                    //int result = command.ExecuteNonQuery();
                    UserDataAccess userDataAccess = new UserDataAccess();

                    if (userDataAccess.UserRegister(user))
                    {
                        MessageBox.Show("User registered successfully");
                        Manager_Info manager_Info = new Manager_Info();
                        manager_Info.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Error in registration");
                    }
                }
            }
           
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Manager_Info manager_Info = new Manager_Info();
            manager_Info.Show();
            this.Hide();
        }
    }
}
