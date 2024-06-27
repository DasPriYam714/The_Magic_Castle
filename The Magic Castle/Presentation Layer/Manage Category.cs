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
    public partial class Manage_Category : Form
    {
        public Manage_Category()
        {
            InitializeComponent();
        }

        private void Manage_Category_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Manage_Category_Load(object sender, EventArgs e)
        {
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            categoryListDataGridView.DataSource = categoryDataAccess.GetAllCategories();

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            AdminHome adminHome = new AdminHome();
            adminHome.Show();
            this.Hide();

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateCategory updateCategory = new UpdateCategory();
            updateCategory.Show();
            this.Hide();
        }

        private void addDeleteButton_Click(object sender, EventArgs e)
        {
            AddOrDelete_Category addOrDelete_Category = new AddOrDelete_Category();
            addOrDelete_Category.Show();
            this.Hide();
        }
    }
}
