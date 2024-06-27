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
    public partial class RemoveManager : Form
    {
        public RemoveManager()
        {
            InitializeComponent();
        }

        private void RemoveManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void RemoveManager_Load(object sender, EventArgs e)
        {
            UserDataAccess userDataAccess = new UserDataAccess();
            managerListDataGridView.DataSource = userDataAccess.GetAllUser();
        }

        void UpdateUserList()
        {
            UserDataAccess userDataAccess = new UserDataAccess();
            managerListDataGridView.DataSource = userDataAccess.GetAllUser();
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                UserDataAccess productDataAccess = new UserDataAccess();
                if (productDataAccess.DeleteUser(Convert.ToInt32(deleteManIdTextBox.Text)))
                {
                    MessageBox.Show("Manager remove successfully");
                    UpdateUserList();
                }
                else
                {
                    MessageBox.Show("Error in removing manager");
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Manager_Info manager_Info = new Manager_Info();
            manager_Info.Show();
            this.Hide();
        }

        private void managerListDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            deleteManIdTextBox.Text = managerListDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
