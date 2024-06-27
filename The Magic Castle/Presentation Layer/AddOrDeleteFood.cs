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
    public partial class AddOrDeleteFood : Form
    {
        public AddOrDeleteFood()
        {
            InitializeComponent();
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            categoryComboBox.DataSource = categoryDataAccess.GetAllCategoryNames();
        }

        private void ManageFoodPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AddOrDeleteFood_Load(object sender, EventArgs e)
        {
            FoodDataAccess foodDataAccess = new FoodDataAccess();
            foodListDataGridView.DataSource = foodDataAccess.GetAllFood();
            categoryComboBox.SelectedIndex = -1;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ManageFood manageFood = new ManageFood();
            manageFood.Show();
            this.Hide();
        }

        void UpdateFoodList()
        {
            FoodDataAccess foodDataAccess = new FoodDataAccess();
            foodListDataGridView.DataSource = foodDataAccess.GetAllFood();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                FoodDataAccess productDataAccess = new FoodDataAccess();
                if (productDataAccess.DeleteFood(Convert.ToInt32(deleteFoodIdTextBox.Text)))
                {
                    MessageBox.Show("Food deleted successfully");
                    UpdateFoodList();
                }
                else
                {
                    MessageBox.Show("Error in deleting food");
                }
            }
        }

        private void foodListDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            deleteFoodIdTextBox.Text = foodListDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        //void UpdateFoodList()
        //{
        //    FoodDataAccess foodDataAccess = new FoodDataAccess();
        //    foodListDataGridView.DataSource = foodDataAccess.GetAllFood();
        //}

        private void addButton_Click(object sender, EventArgs e)
        {
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            int catId = categoryDataAccess.GetCategoryIdByName(categoryComboBox.Text);
            if (catId > 0)
            {
                FoodDataAccess foodDataAccess = new FoodDataAccess();
                if (foodDataAccess.AddNewFood(foodNameTextBox.Text, itemTextBox.Text, Convert.ToDouble(priceTextBox.Text), catId)) 
                {
                    MessageBox.Show("Food added successfully");
                    UpdateFoodList();
                }
                else
                {
                    MessageBox.Show("Error in adding food");
                }
            }
            else
            {
                MessageBox.Show("Category not found");
            }
        }
    }
}
