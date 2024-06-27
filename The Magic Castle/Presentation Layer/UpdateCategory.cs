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
    public partial class UpdateCategory : Form
    {
        public object Update_Category { get; private set; }

        public UpdateCategory()
        {
            InitializeComponent();
        }

        private void UpdateCategory_Load(object sender, EventArgs e)
        {
            
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            categoryListDataGridView.DataSource = categoryDataAccess.GetAllCategories();

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Manage_Category manage_Category = new Manage_Category();
            manage_Category.Show();
            this.Hide();
        }

        private void UpdateCategory_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void categoryListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            catIdTextBox.Text = categoryListDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            catNameTextBox.Text= categoryListDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
        void UpdateCategoryList()
        {
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            categoryListDataGridView.DataSource = categoryDataAccess.GetAllCategories();
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            if (categoryDataAccess.UpdateCategory(Convert.ToInt32(catIdTextBox.Text), catNameTextBox.Text))
            {
                MessageBox.Show("Category updated successfully");
                catIdTextBox.Text = catNameTextBox.Text = "";

                UpdateCategoryList();
            }
            else
            {
                MessageBox.Show("Error in updating");
            }
        }

        
    }
}
