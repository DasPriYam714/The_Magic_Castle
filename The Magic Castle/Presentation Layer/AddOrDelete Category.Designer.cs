
namespace The_Magic_Castle.Presentation_Layer
{
    partial class AddOrDelete_Category
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
            this.addGroupBox = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.catNameLabel = new System.Windows.Forms.Label();
            this.catNameTextBox = new System.Windows.Forms.TextBox();
            this.deleteCategorygroupBox = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.catIdlabel = new System.Windows.Forms.Label();
            this.deleteCatIdTextBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.categoryGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryListDataGridView)).BeginInit();
            this.addGroupBox.SuspendLayout();
            this.deleteCategorygroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoryGroupBox
            // 
            this.categoryGroupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.categoryGroupBox.Controls.Add(this.categoryListDataGridView);
            this.categoryGroupBox.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryGroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.categoryGroupBox.Location = new System.Drawing.Point(252, 40);
            this.categoryGroupBox.Name = "categoryGroupBox";
            this.categoryGroupBox.Size = new System.Drawing.Size(445, 316);
            this.categoryGroupBox.TabIndex = 1;
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
            // addGroupBox
            // 
            this.addGroupBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.addGroupBox.Controls.Add(this.addButton);
            this.addGroupBox.Controls.Add(this.catNameLabel);
            this.addGroupBox.Controls.Add(this.catNameTextBox);
            this.addGroupBox.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addGroupBox.Location = new System.Drawing.Point(12, 453);
            this.addGroupBox.Name = "addGroupBox";
            this.addGroupBox.Size = new System.Drawing.Size(408, 194);
            this.addGroupBox.TabIndex = 2;
            this.addGroupBox.TabStop = false;
            this.addGroupBox.Text = "Add Category";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.addButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addButton.Location = new System.Drawing.Point(240, 119);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(111, 44);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // catNameLabel
            // 
            this.catNameLabel.AutoSize = true;
            this.catNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.catNameLabel.Location = new System.Drawing.Point(6, 77);
            this.catNameLabel.Name = "catNameLabel";
            this.catNameLabel.Size = new System.Drawing.Size(171, 26);
            this.catNameLabel.TabIndex = 3;
            this.catNameLabel.Text = "Category Name";
            // 
            // catNameTextBox
            // 
            this.catNameTextBox.Location = new System.Drawing.Point(215, 63);
            this.catNameTextBox.Name = "catNameTextBox";
            this.catNameTextBox.Size = new System.Drawing.Size(152, 40);
            this.catNameTextBox.TabIndex = 2;
            // 
            // deleteCategorygroupBox
            // 
            this.deleteCategorygroupBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.deleteCategorygroupBox.Controls.Add(this.deleteButton);
            this.deleteCategorygroupBox.Controls.Add(this.catIdlabel);
            this.deleteCategorygroupBox.Controls.Add(this.deleteCatIdTextBox);
            this.deleteCategorygroupBox.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCategorygroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deleteCategorygroupBox.Location = new System.Drawing.Point(496, 453);
            this.deleteCategorygroupBox.Name = "deleteCategorygroupBox";
            this.deleteCategorygroupBox.Size = new System.Drawing.Size(408, 194);
            this.deleteCategorygroupBox.TabIndex = 5;
            this.deleteCategorygroupBox.TabStop = false;
            this.deleteCategorygroupBox.Text = "Delete Category";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deleteButton.Location = new System.Drawing.Point(240, 119);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(111, 44);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // catIdlabel
            // 
            this.catIdlabel.AutoSize = true;
            this.catIdlabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.catIdlabel.Location = new System.Drawing.Point(6, 77);
            this.catIdlabel.Name = "catIdlabel";
            this.catIdlabel.Size = new System.Drawing.Size(133, 26);
            this.catIdlabel.TabIndex = 3;
            this.catIdlabel.Text = "Category Id";
            // 
            // deleteCatIdTextBox
            // 
            this.deleteCatIdTextBox.Location = new System.Drawing.Point(215, 63);
            this.deleteCatIdTextBox.Name = "deleteCatIdTextBox";
            this.deleteCatIdTextBox.Size = new System.Drawing.Size(152, 40);
            this.deleteCatIdTextBox.TabIndex = 2;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(23, 33);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(85, 30);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // AddOrDelete_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::The_Magic_Castle.Properties.Resources.pexels_rajesh_tp_1600711;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(916, 690);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.deleteCategorygroupBox);
            this.Controls.Add(this.addGroupBox);
            this.Controls.Add(this.categoryGroupBox);
            this.Name = "AddOrDelete_Category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddOrDelete_Category";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddOrDelete_Category_FormClosing);
            this.Load += new System.EventHandler(this.AddOrDelete_Category_Load);
            this.categoryGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoryListDataGridView)).EndInit();
            this.addGroupBox.ResumeLayout(false);
            this.addGroupBox.PerformLayout();
            this.deleteCategorygroupBox.ResumeLayout(false);
            this.deleteCategorygroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox categoryGroupBox;
        private System.Windows.Forms.DataGridView categoryListDataGridView;
        private System.Windows.Forms.GroupBox addGroupBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label catNameLabel;
        private System.Windows.Forms.TextBox catNameTextBox;
        private System.Windows.Forms.GroupBox deleteCategorygroupBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label catIdlabel;
        private System.Windows.Forms.TextBox deleteCatIdTextBox;
        private System.Windows.Forms.Button backButton;
    }
}