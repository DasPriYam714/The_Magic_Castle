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
    public partial class Manager_Info : Form
    {
        public Manager_Info()
        {
            InitializeComponent();
        }

        private void Manager_Info_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Manager_Info_Load(object sender, EventArgs e)
        {
            //FoodDataAccess foodDataAccess = new FoodDataAccess();
            //foodListDataGridView.DataSource = foodDataAccess.GetAllFood();
            UserDataAccess userDataAccess = new UserDataAccess();
            managerListDataGridView.DataSource = userDataAccess.GetAllUser();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            AdminHome adminHome = new AdminHome();
            adminHome.Show();
            this.Hide(); 
        }

        private void updateManagerButton_Click(object sender, EventArgs e)
        {
            UpdateManagerInfo updateManagerInfo = new UpdateManagerInfo();
            updateManagerInfo.Show();
            this.Hide(); 
        }

        private void addManagerbutton_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Hide();
        }

        private void removeManagerButton_Click(object sender, EventArgs e)
        {
            RemoveManager removeManager = new RemoveManager();
            removeManager.Show();
            this.Hide();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchManager searchManager = new SearchManager();
            searchManager.Show();
            this.Hide();
        }
    }
}
