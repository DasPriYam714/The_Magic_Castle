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
    public partial class UpdateManagerInfo : Form
    {
        public UpdateManagerInfo()
        {
            InitializeComponent();
            UserDataAccess userDataAccess = new UserDataAccess();
            bloodGroupComboBox.DataSource = userDataAccess.GetAllBloodGroup();
        }

        private void UpdateManagerInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void UpdateManagerInfo_Load(object sender, EventArgs e)
        {
            
            UserDataAccess userDataAccess = new UserDataAccess();
            managerListDataGridView.DataSource = userDataAccess.GetAllUser();
            
            
        }
        void UpdateUserList()
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

        private void managerListDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            manIdTextBox.Text= managerListDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            nameTextBox.Text= managerListDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            usernameTextBox.Text= managerListDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            emailTextBox.Text= managerListDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            passwordTextBox.Text= managerListDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            //dobDateTimePicker.Text= managerListDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            //int Id = (int)managerListDataGridView.Rows[e.RowIndex].Cells[5].Value;
            //UserDataAccess userDataAccess = new UserDataAccess();
            //bloodGroupComboBox.Text = userDataAccess.GetBloodGroupNameById(Id);

        }



        private void updateButton_Click(object sender, EventArgs e)
        {
            UserDataAccess userDataAccess = new UserDataAccess();
            
            if (userDataAccess.UpdateUser(Convert.ToInt32(manIdTextBox.Text), nameTextBox.Text, usernameTextBox.Text, emailTextBox.Text, passwordTextBox.Text ))
            {
                MessageBox.Show("Product updated");
                UpdateUserList();
            }
            else
            {
                MessageBox.Show("Error in updating");
            }
        }
    }
}
