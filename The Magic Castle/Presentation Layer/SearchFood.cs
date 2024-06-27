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
    public partial class SearchFood : Form
    {
        public SearchFood()
        {
            InitializeComponent();
        }

        private void SearchFood_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void SearchFood_Load(object sender, EventArgs e)
        {
            FoodDataAccess foodDataAccess = new FoodDataAccess();
            foodListDataGridView.DataSource = foodDataAccess.GetAllFood();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Login_Dashboard login_Dashboard = new Login_Dashboard();
            login_Dashboard.Show();
            this.Hide();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            FoodDataAccess foodDataAccess = new FoodDataAccess();
            searchDataGridView.DataSource = foodDataAccess.GetFoodByName(searchTextBox.Text);
        }
    }
}
