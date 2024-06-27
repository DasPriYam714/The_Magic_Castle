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
    public partial class AddOrDelete_Category : Form
    {
        public AddOrDelete_Category()
        {
            InitializeComponent();
        }

        private void AddOrDelete_Category_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Manage_Category manage_Category = new Manage_Category();
            manage_Category.Show();
            this.Hide();
        }

        private void AddOrDelete_Category_Load(object sender, EventArgs e)
        {
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            categoryListDataGridView.DataSource = categoryDataAccess.GetAllCategories();
            
        }
        void UpdateCategoryList()
        {
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            categoryListDataGridView.DataSource = categoryDataAccess.GetAllCategories();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            if (categoryDataAccess.AddNewCategory(catNameTextBox.Text))
            {
                MessageBox.Show("Category added succesfully");
                UpdateCategoryList();
            }
            else
            {
                MessageBox.Show("Error in adding category");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
                if (categoryDataAccess.DeleteCategory(Convert.ToInt32(deleteCatIdTextBox.Text)))
                {
                    MessageBox.Show("Category deleted");
                    UpdateCategoryList();
                }
                else
                {
                    MessageBox.Show("Error in deleting");
                }
            }
        }

        private void categoryListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            deleteCatIdTextBox.Text = categoryListDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            
        }
    }
}
