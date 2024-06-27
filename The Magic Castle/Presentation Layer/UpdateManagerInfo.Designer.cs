
namespace The_Magic_Castle.Presentation_Layer
{
    partial class UpdateManagerInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.managerGroupBox = new System.Windows.Forms.GroupBox();
            this.managerListDataGridView = new System.Windows.Forms.DataGridView();
            this.backButton = new System.Windows.Forms.Button();
            this.updateManagerGroupBox = new System.Windows.Forms.GroupBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.bloodGroupComboBox = new System.Windows.Forms.ComboBox();
            this.bloodGroupLabel = new System.Windows.Forms.Label();
            this.dobDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dobLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.manIdTextBox = new System.Windows.Forms.TextBox();
            this.managerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.managerListDataGridView)).BeginInit();
            this.updateManagerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // managerGroupBox
            // 
            this.managerGroupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.managerGroupBox.Controls.Add(this.managerListDataGridView);
            this.managerGroupBox.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerGroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.managerGroupBox.Location = new System.Drawing.Point(262, 41);
            this.managerGroupBox.Name = "managerGroupBox";
            this.managerGroupBox.Size = new System.Drawing.Size(445, 265);
            this.managerGroupBox.TabIndex = 1;
            this.managerGroupBox.TabStop = false;
            this.managerGroupBox.Text = "Manager List";
            // 
            // managerListDataGridView
            // 
            this.managerListDataGridView.AllowUserToAddRows = false;
            this.managerListDataGridView.AllowUserToDeleteRows = false;
            this.managerListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.managerListDataGridView.Location = new System.Drawing.Point(23, 51);
            this.managerListDataGridView.Name = "managerListDataGridView";
            this.managerListDataGridView.ReadOnly = true;
            this.managerListDataGridView.RowHeadersWidth = 51;
            this.managerListDataGridView.RowTemplate.Height = 24;
            this.managerListDataGridView.Size = new System.Drawing.Size(402, 189);
            this.managerListDataGridView.TabIndex = 3;
            this.managerListDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.managerListDataGridView_CellClick);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(12, 41);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 34);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // updateManagerGroupBox
            // 
            this.updateManagerGroupBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.updateManagerGroupBox.Controls.Add(this.updateButton);
            this.updateManagerGroupBox.Controls.Add(this.bloodGroupComboBox);
            this.updateManagerGroupBox.Controls.Add(this.bloodGroupLabel);
            this.updateManagerGroupBox.Controls.Add(this.dobDateTimePicker);
            this.updateManagerGroupBox.Controls.Add(this.dobLabel);
            this.updateManagerGroupBox.Controls.Add(this.passwordLabel);
            this.updateManagerGroupBox.Controls.Add(this.passwordTextBox);
            this.updateManagerGroupBox.Controls.Add(this.emailLabel);
            this.updateManagerGroupBox.Controls.Add(this.emailTextBox);
            this.updateManagerGroupBox.Controls.Add(this.usernameLabel);
            this.updateManagerGroupBox.Controls.Add(this.usernameTextBox);
            this.updateManagerGroupBox.Controls.Add(this.nameLabel);
            this.updateManagerGroupBox.Controls.Add(this.nameTextBox);
            this.updateManagerGroupBox.Controls.Add(this.idLabel);
            this.updateManagerGroupBox.Controls.Add(this.manIdTextBox);
            this.updateManagerGroupBox.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateManagerGroupBox.Location = new System.Drawing.Point(117, 341);
            this.updateManagerGroupBox.Name = "updateManagerGroupBox";
            this.updateManagerGroupBox.Size = new System.Drawing.Size(744, 350);
            this.updateManagerGroupBox.TabIndex = 2;
            this.updateManagerGroupBox.TabStop = false;
            this.updateManagerGroupBox.Text = "Update Manager";
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(471, 268);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(143, 64);
            this.updateButton.TabIndex = 13;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // bloodGroupComboBox
            // 
            this.bloodGroupComboBox.FormattingEnabled = true;
            this.bloodGroupComboBox.Location = new System.Drawing.Point(393, 200);
            this.bloodGroupComboBox.Name = "bloodGroupComboBox";
            this.bloodGroupComboBox.Size = new System.Drawing.Size(261, 31);
            this.bloodGroupComboBox.TabIndex = 3;
            // 
            // bloodGroupLabel
            // 
            this.bloodGroupLabel.AutoSize = true;
            this.bloodGroupLabel.Location = new System.Drawing.Point(372, 158);
            this.bloodGroupLabel.Name = "bloodGroupLabel";
            this.bloodGroupLabel.Size = new System.Drawing.Size(140, 25);
            this.bloodGroupLabel.TabIndex = 12;
            this.bloodGroupLabel.Text = "Blood Group:";
            // 
            // dobDateTimePicker
            // 
            this.dobDateTimePicker.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobDateTimePicker.Location = new System.Drawing.Point(377, 87);
            this.dobDateTimePicker.Name = "dobDateTimePicker";
            this.dobDateTimePicker.Size = new System.Drawing.Size(344, 32);
            this.dobDateTimePicker.TabIndex = 11;
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Location = new System.Drawing.Point(372, 39);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(159, 25);
            this.dobLabel.TabIndex = 10;
            this.dobLabel.Text = "Date Of Birth:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(28, 298);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(108, 25);
            this.passwordLabel.TabIndex = 9;
            this.passwordLabel.Text = "Password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(168, 295);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(162, 37);
            this.passwordTextBox.TabIndex = 8;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(28, 232);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(71, 25);
            this.emailLabel.TabIndex = 7;
            this.emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(168, 220);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(162, 37);
            this.emailTextBox.TabIndex = 6;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(28, 167);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(111, 25);
            this.usernameLabel.TabIndex = 5;
            this.usernameLabel.Text = "Username:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(168, 155);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(162, 37);
            this.usernameTextBox.TabIndex = 4;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(28, 101);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(73, 25);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(168, 89);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(162, 37);
            this.nameTextBox.TabIndex = 2;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(28, 39);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(128, 25);
            this.idLabel.TabIndex = 1;
            this.idLabel.Text = "Manager Id:";
            // 
            // manIdTextBox
            // 
            this.manIdTextBox.Location = new System.Drawing.Point(168, 36);
            this.manIdTextBox.Name = "manIdTextBox";
            this.manIdTextBox.Size = new System.Drawing.Size(162, 37);
            this.manIdTextBox.TabIndex = 0;
            // 
            // UpdateManagerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::The_Magic_Castle.Properties.Resources.pexels_quang_nguyen_vinh_2159065;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(964, 703);
            this.Controls.Add(this.updateManagerGroupBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.managerGroupBox);
            this.Name = "UpdateManagerInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateManagerInfo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdateManagerInfo_FormClosing);
            this.Load += new System.EventHandler(this.UpdateManagerInfo_Load);
            this.managerGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.managerListDataGridView)).EndInit();
            this.updateManagerGroupBox.ResumeLayout(false);
            this.updateManagerGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox managerGroupBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.GroupBox updateManagerGroupBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox manIdTextBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.ComboBox bloodGroupComboBox;
        private System.Windows.Forms.Label bloodGroupLabel;
        private System.Windows.Forms.DateTimePicker dobDateTimePicker;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.DataGridView managerListDataGridView;
    }
}