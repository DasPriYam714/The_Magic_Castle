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
    public partial class ManageFood : Form
    {
        public ManageFood()
        {
            InitializeComponent();
        }

        private void ManageFood_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ManageFood_Load(object sender, EventArgs e)
        {
            FoodDataAccess foodDataAccess = new FoodDataAccess();
            foodListDataGridView.DataSource = foodDataAccess.GetAllFood();

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            AdminHome adminHome = new AdminHome();
            adminHome.Show();
            this.Hide();
        }

        private void addDeleteButton_Click(object sender, EventArgs e)
        {
            AddOrDeleteFood addOrDeleteFood = new AddOrDeleteFood();
            addOrDeleteFood.Show();
            this.Hide();
        }

        private void updateFoodButton_Click(object sender, EventArgs e)
        {
            UpdateFood updateFood = new UpdateFood();
            updateFood.Show();
            this.Hide();
        }
    }
}
