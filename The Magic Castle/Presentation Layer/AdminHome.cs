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
    public partial class AdminHome : Form
    {
        //private object adminLogin;

        public AdminHome()
        {
            InitializeComponent();
        }

        private void AdminHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Hide();
        }

        private void manageCategoryButton_Click(object sender, EventArgs e)
        {
            Manage_Category manageCategory = new Manage_Category();
            manageCategory.Show();
            this.Hide();

        }

        private void manageFoodButton_Click(object sender, EventArgs e)
        {
            ManageFood manageFood = new ManageFood();
            manageFood.Show();
            this.Hide();
        }

        private void mDetailsButton_Click(object sender, EventArgs e)
        {
            Manager_Info manager_Info = new Manager_Info();
            manager_Info.Show();
            this.Hide();
        }
    }
}
