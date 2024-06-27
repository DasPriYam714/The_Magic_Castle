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
    public partial class Login_Dashboard : Form
    {
        public Login_Dashboard()
        {
            InitializeComponent();
        }

        private void Login_Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Hide();


        }

        private void updateFoodButton_Click(object sender, EventArgs e)
        {
            ManagerUpdateFood managerUpdateFood = new ManagerUpdateFood();
            managerUpdateFood.Show();
            this.Hide();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchFood searchFood = new SearchFood();
            searchFood.Show();
            this.Hide();
        }
    }
}
