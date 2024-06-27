
namespace The_Magic_Castle.Presentation_Layer
{
    partial class AddOrDeleteFood
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
            this.foodListGroupBox = new System.Windows.Forms.GroupBox();
            this.foodListDataGridView = new System.Windows.Forms.DataGridView();
            this.addGroupBox = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.foodNameLabel = new System.Windows.Forms.Label();
            this.foodNameTextBox = new System.Windows.Forms.TextBox();
            this.itemLabel = new System.Windows.Forms.Label();
            this.itemTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.deleteFoodGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.foodIdlabel = new System.Windows.Forms.Label();
            this.deleteFoodIdTextBox = new System.Windows.Forms.TextBox();
            this.foodListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodListDataGridView)).BeginInit();
            this.addGroupBox.SuspendLayout();
            this.deleteFoodGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // foodListGroupBox
            // 
            this.foodListGroupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.foodListGroupBox.Controls.Add(this.foodListDataGridView);
            this.foodListGroupBox.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodListGroupBox.Location = new System.Drawing.Point(207, 38);
            this.foodListGroupBox.Name = "foodListGroupBox";
            this.foodListGroupBox.Size = new System.Drawing.Size(538, 361);
            this.foodListGroupBox.TabIndex = 1;
            this.foodListGroupBox.TabStop = false;
            this.foodListGroupBox.Text = "Food List";
            // 
            // foodListDataGridView
            // 
            this.foodListDataGridView.AllowUserToAddRows = false;
            this.foodListDataGridView.AllowUserToDeleteRows = false;
            this.foodListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foodListDataGridView.Location = new System.Drawing.Point(35, 39);
            this.foodListDataGridView.Name = "foodListDataGridView";
            this.foodListDataGridView.ReadOnly = true;
            this.foodListDataGridView.RowHeadersWidth = 51;
            this.foodListDataGridView.RowTemplate.Height = 24;
            this.foodListDataGridView.Size = new System.Drawing.Size(466, 285);
            this.foodListDataGridView.TabIndex = 0;
            this.foodListDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.foodListDataGridView_CellClick);
            // 
            // addGroupBox
            // 
            this.addGroupBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.addGroupBox.Controls.Add(this.categoryLabel);
            this.addGroupBox.Controls.Add(this.categoryComboBox);
            this.addGroupBox.Controls.Add(this.priceLabel);
            this.addGroupBox.Controls.Add(this.priceTextBox);
            this.addGroupBox.Controls.Add(this.itemLabel);
            this.addGroupBox.Controls.Add(this.itemTextBox);
            this.addGroupBox.Controls.Add(this.addButton);
            this.addGroupBox.Controls.Add(this.foodNameLabel);
            this.addGroupBox.Controls.Add(this.foodNameTextBox);
            this.addGroupBox.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addGroupBox.Location = new System.Drawing.Point(29, 478);
            this.addGroupBox.Name = "addGroupBox";
            this.addGroupBox.Size = new System.Drawing.Size(408, 317);
            this.addGroupBox.TabIndex = 3;
            this.addGroupBox.TabStop = false;
            this.addGroupBox.Text = "Add Food";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.addButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addButton.Location = new System.Drawing.Point(256, 267);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(111, 44);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // foodNameLabel
            // 
            this.foodNameLabel.AutoSize = true;
            this.foodNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.foodNameLabel.Location = new System.Drawing.Point(6, 51);
            this.foodNameLabel.Name = "foodNameLabel";
            this.foodNameLabel.Size = new System.Drawing.Size(128, 26);
            this.foodNameLabel.TabIndex = 3;
            this.foodNameLabel.Text = "Food Name";
            // 
            // foodNameTextBox
            // 
            this.foodNameTextBox.Location = new System.Drawing.Point(178, 48);
            this.foodNameTextBox.Name = "foodNameTextBox";
            this.foodNameTextBox.Size = new System.Drawing.Size(189, 40);
            this.foodNameTextBox.TabIndex = 2;
            // 
            // itemLabel
            // 
            this.itemLabel.AutoSize = true;
            this.itemLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.itemLabel.Location = new System.Drawing.Point(6, 109);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(60, 26);
            this.itemLabel.TabIndex = 6;
            this.itemLabel.Text = "Item";
            // 
            // itemTextBox
            // 
            this.itemTextBox.Location = new System.Drawing.Point(178, 106);
            this.itemTextBox.Name = "itemTextBox";
            this.itemTextBox.Size = new System.Drawing.Size(189, 40);
            this.itemTextBox.TabIndex = 5;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.priceLabel.Location = new System.Drawing.Point(6, 164);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(63, 26);
            this.priceLabel.TabIndex = 8;
            this.priceLabel.Text = "Price";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(178, 161);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(189, 40);
            this.priceTextBox.TabIndex = 7;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(178, 217);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(189, 34);
            this.categoryComboBox.TabIndex = 9;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.categoryLabel.Location = new System.Drawing.Point(6, 220);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(103, 26);
            this.categoryLabel.TabIndex = 10;
            this.categoryLabel.Text = "Category";
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(23, 38);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(83, 38);
            this.backButton.TabIndex = 11;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // deleteFoodGroupBox
            // 
            this.deleteFoodGroupBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.deleteFoodGroupBox.Controls.Add(this.deleteButton);
            this.deleteFoodGroupBox.Controls.Add(this.foodIdlabel);
            this.deleteFoodGroupBox.Controls.Add(this.deleteFoodIdTextBox);
            this.deleteFoodGroupBox.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteFoodGroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deleteFoodGroupBox.Location = new System.Drawing.Point(530, 544);
            this.deleteFoodGroupBox.Name = "deleteFoodGroupBox";
            this.deleteFoodGroupBox.Size = new System.Drawing.Size(408, 194);
            this.deleteFoodGroupBox.TabIndex = 6;
            this.deleteFoodGroupBox.TabStop = false;
            this.deleteFoodGroupBox.Text = "Delete Food";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deleteButton.Location = new System.Drawing.Point(256, 119);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(111, 44);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // foodIdlabel
            // 
            this.foodIdlabel.AutoSize = true;
            this.foodIdlabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.foodIdlabel.Location = new System.Drawing.Point(6, 77);
            this.foodIdlabel.Name = "foodIdlabel";
            this.foodIdlabel.Size = new System.Drawing.Size(90, 26);
            this.foodIdlabel.TabIndex = 3;
            this.foodIdlabel.Text = "Food Id";
            // 
            // deleteFoodIdTextBox
            // 
            this.deleteFoodIdTextBox.Location = new System.Drawing.Point(155, 63);
            this.deleteFoodIdTextBox.Name = "deleteFoodIdTextBox";
            this.deleteFoodIdTextBox.Size = new System.Drawing.Size(212, 40);
            this.deleteFoodIdTextBox.TabIndex = 2;
            // 
            // AddOrDeleteFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::The_Magic_Castle.Properties.Resources.pexels_frans_van_heerden_670705;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(966, 851);
            this.Controls.Add(this.deleteFoodGroupBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.addGroupBox);
            this.Controls.Add(this.foodListGroupBox);
            this.Name = "AddOrDeleteFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageFoodPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageFoodPage_FormClosing);
            this.Load += new System.EventHandler(this.AddOrDeleteFood_Load);
            this.foodListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.foodListDataGridView)).EndInit();
            this.addGroupBox.ResumeLayout(false);
            this.addGroupBox.PerformLayout();
            this.deleteFoodGroupBox.ResumeLayout(false);
            this.deleteFoodGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox foodListGroupBox;
        private System.Windows.Forms.DataGridView foodListDataGridView;
        private System.Windows.Forms.GroupBox addGroupBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label itemLabel;
        private System.Windows.Forms.TextBox itemTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label foodNameLabel;
        private System.Windows.Forms.TextBox foodNameTextBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.GroupBox deleteFoodGroupBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label foodIdlabel;
        private System.Windows.Forms.TextBox deleteFoodIdTextBox;
    }
}