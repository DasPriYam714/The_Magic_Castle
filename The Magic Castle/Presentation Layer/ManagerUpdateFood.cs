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
    public partial class ManagerUpdateFood : Form
    {
        public ManagerUpdateFood()
        {
            InitializeComponent();
        }

        private void ManagerUpdateFood_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void foodListDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foodIdTextBox.Text = foodListDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            foodNameTextBox.Text = foodListDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            itemTextBox.Text = foodListDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            priceTextBox.Text = foodListDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            int catId = (int)foodListDataGridView.Rows[e.RowIndex].Cells[4].Value;
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            categoryComboBox.Text = categoryDataAccess.GetCategoryNameById(catId);
        }

        void UpdateFoodList()
        {
            FoodDataAccess foodDataAccess = new FoodDataAccess();
            foodListDataGridView.DataSource = foodDataAccess.GetAllFood();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            FoodDataAccess productDataAccess = new FoodDataAccess();
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            int catId = categoryDataAccess.GetCategoryIdByName(categoryComboBox.Text);
            if (productDataAccess.UpdateFood(Convert.ToInt32(foodIdTextBox.Text), foodNameTextBox.Text, itemTextBox.Text, Convert.ToDouble(priceTextBox.Text), catId))
            {
                MessageBox.Show("Food updated successfully");
                UpdateFoodList();
            }
            else
            {
                MessageBox.Show("Error in updating food");
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Login_Dashboard login_Dashboard = new Login_Dashboard();
            login_Dashboard.Show();
            this.Hide();
        }

        private void ManagerUpdateFood_Load(object sender, EventArgs e)
        {
            FoodDataAccess foodDataAccess = new FoodDataAccess();
            foodListDataGridView.DataSource = foodDataAccess.GetAllFood();
            categoryComboBox.SelectedIndex = -1;
        }
    }
}
