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
    public partial class SearchManager : Form
    {
        public SearchManager()
        {
            InitializeComponent();
        }

        private void SearchManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void SearchManager_Load(object sender, EventArgs e)
        {
            UserDataAccess userDataAccess = new UserDataAccess();
            managerListDataGridView.DataSource = userDataAccess.GetAllUser();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Manager_Info manager_Info = new Manager_Info();
            manager_Info.Show();
            this.Hide();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            UserDataAccess userDataAccess = new UserDataAccess();
            searchManagerDataGridView.DataSource = userDataAccess.GetUserByName(searchTextBox.Text);
        }
    }
}
