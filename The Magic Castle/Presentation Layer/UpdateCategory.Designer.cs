
namespace The_Magic_Castle.Presentation_Layer
{
    partial class UpdateCategory
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
            this.categoryGroupBox = new System.Windows.Forms.GroupBox();
            this.categoryListDataGridView = new System.Windows.Forms.DataGridView();
            this.updateGroupBox = new System.Windows.Forms.GroupBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.catNameLabel = new System.Windows.Forms.Label();
            this.catNameTextBox = new System.Windows.Forms.TextBox();
            this.catIdLabel = new System.Windows.Forms.Label();
            this.catIdTextBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.categoryGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryListDataGridView)).BeginInit();
            this.updateGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoryGroupBox
            // 
            this.categoryGroupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.categoryGroupBox.Controls.Add(this.categoryListDataGridView);
            this.categoryGroupBox.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryGroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.categoryGroupBox.Location = new System.Drawing.Point(226, 50);
            this.categoryGroupBox.Name = "categoryGroupBox";
            this.categoryGroupBox.Size = new System.Drawing.Size(445, 316);
            this.categoryGroupBox.TabIndex = 0;
            this.categoryGroupBox.TabStop = false;
            this.categoryGroupBox.Text = "Category List";
            // 
            // categoryListDataGridView
            // 
            this.categoryListDataGridView.AllowUserToAddRows = false;
            this.categoryListDataGridView.AllowUserToDeleteRows = false;
            this.categoryListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryListDataGridView.Location = new System.Drawing.Point(29, 39);
            this.categoryListDataGridView.Name = "categoryListDataGridView";
            this.categoryListDataGridView.ReadOnly = true;
            this.categoryListDataGridView.RowHeadersWidth = 51;
            this.categoryListDataGridView.RowTemplate.Height = 24;
            this.categoryListDataGridView.Size = new System.Drawing.Size(390, 241);
            this.categoryListDataGridView.TabIndex = 0;
            this.categoryListDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoryListDataGridView_CellContentClick);
            // 
            // updateGroupBox
            // 
            this.updateGroupBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.updateGroupBox.Controls.Add(this.updateButton);
            this.updateGroupBox.Controls.Add(this.catNameLabel);
            this.updateGroupBox.Controls.Add(this.catNameTextBox);
            this.updateGroupBox.Controls.Add(this.catIdLabel);
            this.updateGroupBox.Controls.Add(this.catIdTextBox);
            this.updateGroupBox.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateGroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updateGroupBox.Location = new System.Drawing.Point(126, 425);
            this.updateGroupBox.Name = "updateGroupBox";
            this.updateGroupBox.Size = new System.Drawing.Size(657, 222);
            this.updateGroupBox.TabIndex = 1;
            this.updateGroupBox.TabStop = false;
            this.updateGroupBox.Text = "Update Category";
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.updateButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updateButton.Location = new System.Drawing.Point(302, 161);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(111, 44);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // catNameLabel
            // 
            this.catNameLabel.AutoSize = true;
            this.catNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.catNameLabel.Location = new System.Drawing.Point(73, 101);
            this.catNameLabel.Name = "catNameLabel";
            this.catNameLabel.Size = new System.Drawing.Size(171, 26);
            this.catNameLabel.TabIndex = 3;
            this.catNameLabel.Text = "Category Name";
            // 
            // catNameTextBox
            // 
            this.catNameTextBox.Location = new System.Drawing.Point(288, 98);
            this.catNameTextBox.Name = "catNameTextBox";
            this.catNameTextBox.Size = new System.Drawing.Size(257, 40);
            this.catNameTextBox.TabIndex = 2;
            // 
            // catIdLabel
            // 
            this.catIdLabel.AutoSize = true;
            this.catIdLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.catIdLabel.Location = new System.Drawing.Point(73, 55);
            this.catIdLabel.Name = "catIdLabel";
            this.catIdLabel.Size = new System.Drawing.Size(133, 26);
            this.catIdLabel.TabIndex = 1;
            this.catIdLabel.Text = "Category Id";
            // 
            // catIdTextBox
            // 
            this.catIdTextBox.Location = new System.Drawing.Point(288, 52);
            this.catIdTextBox.Name = "catIdTextBox";
            this.catIdTextBox.Size = new System.Drawing.Size(257, 40);
            this.catIdTextBox.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.backButton.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backButton.Location = new System.Drawing.Point(24, 31);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(103, 42);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // UpdateCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::The_Magic_Castle.Properties.Resources.pexels_brigitte_tohm_143640;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(905, 675);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.updateGroupBox);
            this.Controls.Add(this.categoryGroupBox);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "UpdateCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateCategory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdateCategory_FormClosing);
            this.Load += new System.EventHandler(this.UpdateCategory_Load);
            this.categoryGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoryListDataGridView)).EndInit();
            this.updateGroupBox.ResumeLayout(false);
            this.updateGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox categoryGroupBox;
        private System.Windows.Forms.DataGridView categoryListDataGridView;
        private System.Windows.Forms.GroupBox updateGroupBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label catNameLabel;
        private System.Windows.Forms.TextBox catNameTextBox;
        private System.Windows.Forms.Label catIdLabel;
        private System.Windows.Forms.TextBox catIdTextBox;
        private System.Windows.Forms.Button backButton;
    }
}