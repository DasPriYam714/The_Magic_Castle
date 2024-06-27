
namespace The_Magic_Castle.Presentation_Layer
{
    partial class AdminHome
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
            this.manageCategoryButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.mDetailsButton = new System.Windows.Forms.Button();
            this.manageFoodButton = new System.Windows.Forms.Button();
            this.adminLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // manageCategoryButton
            // 
            this.manageCategoryButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.manageCategoryButton.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageCategoryButton.Location = new System.Drawing.Point(50, 52);
            this.manageCategoryButton.Name = "manageCategoryButton";
            this.manageCategoryButton.Size = new System.Drawing.Size(142, 66);
            this.manageCategoryButton.TabIndex = 0;
            this.manageCategoryButton.Text = "Manage Category";
            this.manageCategoryButton.UseVisualStyleBackColor = false;
            this.manageCategoryButton.Click += new System.EventHandler(this.manageCategoryButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.logoutButton.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(50, 525);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(142, 66);
            this.logoutButton.TabIndex = 1;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // mDetailsButton
            // 
            this.mDetailsButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.mDetailsButton.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mDetailsButton.Location = new System.Drawing.Point(50, 364);
            this.mDetailsButton.Name = "mDetailsButton";
            this.mDetailsButton.Size = new System.Drawing.Size(142, 66);
            this.mDetailsButton.TabIndex = 3;
            this.mDetailsButton.Text = "Manager Info";
            this.mDetailsButton.UseVisualStyleBackColor = false;
            this.mDetailsButton.Click += new System.EventHandler(this.mDetailsButton_Click);
            // 
            // manageFoodButton
            // 
            this.manageFoodButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.manageFoodButton.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageFoodButton.Location = new System.Drawing.Point(50, 189);
            this.manageFoodButton.Name = "manageFoodButton";
            this.manageFoodButton.Size = new System.Drawing.Size(142, 66);
            this.manageFoodButton.TabIndex = 4;
            this.manageFoodButton.Text = "Manage Food";
            this.manageFoodButton.UseVisualStyleBackColor = false;
            this.manageFoodButton.Click += new System.EventHandler(this.manageFoodButton_Click);
            // 
            // adminLabel
            // 
            this.adminLabel.AutoSize = true;
            this.adminLabel.BackColor = System.Drawing.Color.Silver;
            this.adminLabel.Font = new System.Drawing.Font("Niagara Solid", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLabel.ForeColor = System.Drawing.Color.OliveDrab;
            this.adminLabel.Location = new System.Drawing.Point(404, 262);
            this.adminLabel.Name = "adminLabel";
            this.adminLabel.Size = new System.Drawing.Size(405, 128);
            this.adminLabel.TabIndex = 8;
            this.adminLabel.Text = "Admin Panel";
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::The_Magic_Castle.Properties.Resources._7066870;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(962, 662);
            this.Controls.Add(this.adminLabel);
            this.Controls.Add(this.manageFoodButton);
            this.Controls.Add(this.mDetailsButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.manageCategoryButton);
            this.Font = new System.Drawing.Font("Modern No. 20", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AdminHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminHome_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button manageCategoryButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button mDetailsButton;
        private System.Windows.Forms.Button manageFoodButton;
        private System.Windows.Forms.Label adminLabel;
    }
}