
namespace The_Magic_Castle.Presentation_Layer
{
    partial class Manage_Category
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
            this.categoryListGroupBox = new System.Windows.Forms.GroupBox();
            this.categoryListDataGridView = new System.Windows.Forms.DataGridView();
            this.addDeleteButton = new System.Windows.Forms.Button();
            this.updateCategoryButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.categoryListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryListGroupBox
            // 
            this.categoryListGroupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.categoryListGroupBox.Controls.Add(this.categoryListDataGridView);
            this.categoryListGroupBox.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryListGroupBox.Location = new System.Drawing.Point(241, 62);
            this.categoryListGroupBox.Name = "categoryListGroupBox";
            this.categoryListGroupBox.Size = new System.Drawing.Size(505, 422);
            this.categoryListGroupBox.TabIndex = 0;
            this.categoryListGroupBox.TabStop = false;
            this.categoryListGroupBox.Text = "Category List";
            // 
            // categoryListDataGridView
            // 
            this.categoryListDataGridView.AllowUserToAddRows = false;
            this.categoryListDataGridView.AllowUserToDeleteRows = false;
            this.categoryListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryListDataGridView.Location = new System.Drawing.Point(39, 44);
            this.categoryListDataGridView.Name = "categoryListDataGridView";
            this.categoryListDataGridView.ReadOnly = true;
            this.categoryListDataGridView.RowHeadersWidth = 51;
            this.categoryListDataGridView.RowTemplate.Height = 24;
            this.categoryListDataGridView.Size = new System.Drawing.Size(425, 339);
            this.categoryListDataGridView.TabIndex = 0;
            // 
            // addDeleteButton
            // 
            this.addDeleteButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.addDeleteButton.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDeleteButton.Location = new System.Drawing.Point(784, 613);
            this.addDeleteButton.Name = "addDeleteButton";
            this.addDeleteButton.Size = new System.Drawing.Size(152, 70);
            this.addDeleteButton.TabIndex = 1;
            this.addDeleteButton.Text = "Add/Delete Category";
            this.addDeleteButton.UseVisualStyleBackColor = false;
            this.addDeleteButton.Click += new System.EventHandler(this.addDeleteButton_Click);
            // 
            // updateCategoryButton
            // 
            this.updateCategoryButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.updateCategoryButton.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCategoryButton.Location = new System.Drawing.Point(1071, 507);
            this.updateCategoryButton.Name = "updateCategoryButton";
            this.updateCategoryButton.Size = new System.Drawing.Size(131, 70);
            this.updateCategoryButton.TabIndex = 2;
            this.updateCategoryButton.Text = "Update Category";
            this.updateCategoryButton.UseVisualStyleBackColor = false;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.backButton.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(23, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(131, 39);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.updateButton.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(41, 613);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(152, 70);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "Update Category";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // Manage_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::The_Magic_Castle.Properties.Resources.pexels_pixabay_262978;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(961, 774);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.updateCategoryButton);
            this.Controls.Add(this.addDeleteButton);
            this.Controls.Add(this.categoryListGroupBox);
            this.Name = "Manage_Category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage_Category";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Manage_Category_FormClosing);
            this.Load += new System.EventHandler(this.Manage_Category_Load);
            this.categoryListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoryListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox categoryListGroupBox;
        private System.Windows.Forms.DataGridView categoryListDataGridView;
        private System.Windows.Forms.Button addDeleteButton;
        private System.Windows.Forms.Button updateCategoryButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button updateButton;
    }
}