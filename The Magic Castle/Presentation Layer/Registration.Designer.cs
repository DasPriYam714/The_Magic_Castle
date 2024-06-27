
namespace The_Magic_Castle.Presentation_Layer
{
    partial class Registration
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
            this.registrationGroupBox = new System.Windows.Forms.GroupBox();
            this.termCheckBox = new System.Windows.Forms.CheckBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.bloodGroupComboBox = new System.Windows.Forms.ComboBox();
            this.dateofbirthLabel = new System.Windows.Forms.Label();
            this.bloodGroupLabel = new System.Windows.Forms.Label();
            this.dobDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backButton = new System.Windows.Forms.Button();
            this.registrationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // registrationGroupBox
            // 
            this.registrationGroupBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.registrationGroupBox.Controls.Add(this.termCheckBox);
            this.registrationGroupBox.Controls.Add(this.confirmButton);
            this.registrationGroupBox.Controls.Add(this.bloodGroupComboBox);
            this.registrationGroupBox.Controls.Add(this.dateofbirthLabel);
            this.registrationGroupBox.Controls.Add(this.bloodGroupLabel);
            this.registrationGroupBox.Controls.Add(this.dobDateTimePicker);
            this.registrationGroupBox.Controls.Add(this.confirmPasswordLabel);
            this.registrationGroupBox.Controls.Add(this.confirmPasswordTextBox);
            this.registrationGroupBox.Controls.Add(this.passwordLabel);
            this.registrationGroupBox.Controls.Add(this.passwordTextBox);
            this.registrationGroupBox.Controls.Add(this.emailLabel);
            this.registrationGroupBox.Controls.Add(this.emailTextBox);
            this.registrationGroupBox.Controls.Add(this.usernameLabel);
            this.registrationGroupBox.Controls.Add(this.usernameTextBox);
            this.registrationGroupBox.Controls.Add(this.nameLabel);
            this.registrationGroupBox.Controls.Add(this.nameTextBox);
            this.registrationGroupBox.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationGroupBox.Location = new System.Drawing.Point(111, 26);
            this.registrationGroupBox.Name = "registrationGroupBox";
            this.registrationGroupBox.Size = new System.Drawing.Size(773, 673);
            this.registrationGroupBox.TabIndex = 0;
            this.registrationGroupBox.TabStop = false;
            this.registrationGroupBox.Text = "Registration";
            // 
            // termCheckBox
            // 
            this.termCheckBox.AutoSize = true;
            this.termCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.termCheckBox.Location = new System.Drawing.Point(163, 560);
            this.termCheckBox.Name = "termCheckBox";
            this.termCheckBox.Size = new System.Drawing.Size(497, 35);
            this.termCheckBox.TabIndex = 15;
            this.termCheckBox.Text = "I will agree all terms annd conditions";
            this.termCheckBox.UseVisualStyleBackColor = false;
            this.termCheckBox.CheckedChanged += new System.EventHandler(this.termCheckBox_CheckedChanged);
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.confirmButton.Location = new System.Drawing.Point(327, 619);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(128, 48);
            this.confirmButton.TabIndex = 14;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // bloodGroupComboBox
            // 
            this.bloodGroupComboBox.FormattingEnabled = true;
            this.bloodGroupComboBox.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.bloodGroupComboBox.Location = new System.Drawing.Point(327, 491);
            this.bloodGroupComboBox.Name = "bloodGroupComboBox";
            this.bloodGroupComboBox.Size = new System.Drawing.Size(322, 37);
            this.bloodGroupComboBox.TabIndex = 13;
            // 
            // dateofbirthLabel
            // 
            this.dateofbirthLabel.AutoSize = true;
            this.dateofbirthLabel.Location = new System.Drawing.Point(76, 425);
            this.dateofbirthLabel.Name = "dateofbirthLabel";
            this.dateofbirthLabel.Size = new System.Drawing.Size(185, 31);
            this.dateofbirthLabel.TabIndex = 12;
            this.dateofbirthLabel.Text = "Date of Birth";
            // 
            // bloodGroupLabel
            // 
            this.bloodGroupLabel.AutoSize = true;
            this.bloodGroupLabel.Location = new System.Drawing.Point(76, 497);
            this.bloodGroupLabel.Name = "bloodGroupLabel";
            this.bloodGroupLabel.Size = new System.Drawing.Size(163, 31);
            this.bloodGroupLabel.TabIndex = 11;
            this.bloodGroupLabel.Text = "Blood Group";
            // 
            // dobDateTimePicker
            // 
            this.dobDateTimePicker.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobDateTimePicker.Location = new System.Drawing.Point(327, 421);
            this.dobDateTimePicker.Name = "dobDateTimePicker";
            this.dobDateTimePicker.Size = new System.Drawing.Size(322, 35);
            this.dobDateTimePicker.TabIndex = 10;
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Location = new System.Drawing.Point(76, 365);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(231, 31);
            this.confirmPasswordLabel.TabIndex = 9;
            this.confirmPasswordLabel.Text = "Confirm Password";
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(327, 351);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.PasswordChar = '*';
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(322, 45);
            this.confirmPasswordTextBox.TabIndex = 8;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(76, 294);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(124, 31);
            this.passwordLabel.TabIndex = 7;
            this.passwordLabel.Text = "Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.passwordTextBox.Location = new System.Drawing.Point(327, 280);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(322, 45);
            this.passwordTextBox.TabIndex = 6;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(76, 221);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(78, 31);
            this.emailLabel.TabIndex = 5;
            this.emailLabel.Text = "Email";
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.emailTextBox.Location = new System.Drawing.Point(327, 207);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(322, 45);
            this.emailTextBox.TabIndex = 4;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(76, 147);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(129, 31);
            this.usernameLabel.TabIndex = 3;
            this.usernameLabel.Text = "Username";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.usernameTextBox.Location = new System.Drawing.Point(327, 133);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(322, 45);
            this.usernameTextBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(76, 74);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(82, 31);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.nameTextBox.Location = new System.Drawing.Point(327, 60);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(322, 45);
            this.nameTextBox.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.backButton.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(12, 26);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(92, 41);
            this.backButton.TabIndex = 15;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::The_Magic_Castle.Properties.Resources.istockphoto_104704117_170667a;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(975, 720);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.registrationGroupBox);
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Registration_FormClosing);
            this.registrationGroupBox.ResumeLayout(false);
            this.registrationGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox registrationGroupBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ComboBox bloodGroupComboBox;
        private System.Windows.Forms.Label dateofbirthLabel;
        private System.Windows.Forms.Label bloodGroupLabel;
        private System.Windows.Forms.DateTimePicker dobDateTimePicker;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.CheckBox termCheckBox;
    }
}