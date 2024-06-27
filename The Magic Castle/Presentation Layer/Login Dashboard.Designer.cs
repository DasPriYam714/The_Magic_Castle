
namespace The_Magic_Castle.Presentation_Layer
{
    partial class Login_Dashboard
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
            this.logoutButton = new System.Windows.Forms.Button();
            this.updateFoodButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.tmcLabel = new System.Windows.Forms.Label();
            this.restaurentLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.logoutButton.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(19, 116);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(219, 92);
            this.logoutButton.TabIndex = 1;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // updateFoodButton
            // 
            this.updateFoodButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.updateFoodButton.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateFoodButton.Location = new System.Drawing.Point(19, 326);
            this.updateFoodButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.updateFoodButton.Name = "updateFoodButton";
            this.updateFoodButton.Size = new System.Drawing.Size(219, 92);
            this.updateFoodButton.TabIndex = 2;
            this.updateFoodButton.Text = "Update Food";
            this.updateFoodButton.UseVisualStyleBackColor = false;
            this.updateFoodButton.Click += new System.EventHandler(this.updateFoodButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.searchButton.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(19, 532);
            this.searchButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(219, 92);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search Food";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // tmcLabel
            // 
            this.tmcLabel.AutoSize = true;
            this.tmcLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tmcLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tmcLabel.Font = new System.Drawing.Font("MV Boli", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tmcLabel.Location = new System.Drawing.Point(379, 35);
            this.tmcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tmcLabel.Name = "tmcLabel";
            this.tmcLabel.Size = new System.Drawing.Size(695, 212);
            this.tmcLabel.TabIndex = 4;
            this.tmcLabel.Text = "The Magic Castle\r\n Restaurant";
            this.tmcLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // restaurentLabel
            // 
            this.restaurentLabel.AutoSize = true;
            this.restaurentLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.restaurentLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.restaurentLabel.Font = new System.Drawing.Font("MV Boli", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restaurentLabel.Location = new System.Drawing.Point(530, 620);
            this.restaurentLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.restaurentLabel.Name = "restaurentLabel";
            this.restaurentLabel.Size = new System.Drawing.Size(451, 81);
            this.restaurentLabel.TabIndex = 5;
            this.restaurentLabel.Text = "Manager Panel";
            this.restaurentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::The_Magic_Castle.Properties.Resources.alpen_rose_burger;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1294, 781);
            this.Controls.Add(this.restaurentLabel);
            this.Controls.Add(this.tmcLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.updateFoodButton);
            this.Controls.Add(this.logoutButton);
            this.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Login_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_Dashboard_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button updateFoodButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label tmcLabel;
        private System.Windows.Forms.Label restaurentLabel;
    }
}