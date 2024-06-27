
namespace The_Magic_Castle.Presentation_Layer
{
    partial class UpdateFood
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
            this.updateFoodGroupBox = new System.Windows.Forms.GroupBox();
            this.foodIdLabel = new System.Windows.Forms.Label();
            this.foodIdTextBox = new System.Windows.Forms.TextBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.itemLabel = new System.Windows.Forms.Label();
            this.itemTextBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.foodNameLabel = new System.Windows.Forms.Label();
            this.foodNameTextBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.foodListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodListDataGridView)).BeginInit();
            this.updateFoodGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // foodListGroupBox
            // 
            this.foodListGroupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.foodListGroupBox.Controls.Add(this.foodListDataGridView);
            this.foodListGroupBox.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodListGroupBox.Location = new System.Drawing.Point(219, 31);
            this.foodListGroupBox.Name = "foodListGroupBox";
            this.foodListGroupBox.Size = new System.Drawing.Size(538, 361);
            this.foodListGroupBox.TabIndex = 2;
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
            // updateFoodGroupBox
            // 
            this.updateFoodGroupBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.updateFoodGroupBox.Controls.Add(this.foodIdLabel);
            this.updateFoodGroupBox.Controls.Add(this.foodIdTextBox);
            this.updateFoodGroupBox.Controls.Add(this.categoryLabel);
            this.updateFoodGroupBox.Controls.Add(this.categoryComboBox);
            this.updateFoodGroupBox.Controls.Add(this.priceLabel);
            this.updateFoodGroupBox.Controls.Add(this.priceTextBox);
            this.updateFoodGroupBox.Controls.Add(this.itemLabel);
            this.updateFoodGroupBox.Controls.Add(this.itemTextBox);
            this.updateFoodGroupBox.Controls.Add(this.updateButton);
            this.updateFoodGroupBox.Controls.Add(this.foodNameLabel);
            this.updateFoodGroupBox.Controls.Add(this.foodNameTextBox);
            this.updateFoodGroupBox.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateFoodGroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updateFoodGroupBox.Location = new System.Drawing.Point(141, 436);
            this.updateFoodGroupBox.Name = "updateFoodGroupBox";
            this.updateFoodGroupBox.Size = new System.Drawing.Size(693, 377);
            this.updateFoodGroupBox.TabIndex = 4;
            this.updateFoodGroupBox.TabStop = false;
            this.updateFoodGroupBox.Text = "Update Food";
            // 
            // foodIdLabel
            // 
            this.foodIdLabel.AutoSize = true;
            this.foodIdLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.foodIdLabel.Location = new System.Drawing.Point(18, 53);
            this.foodIdLabel.Name = "foodIdLabel";
            this.foodIdLabel.Size = new System.Drawing.Size(90, 26);
            this.foodIdLabel.TabIndex = 12;
            this.foodIdLabel.Text = "Food Id";
            // 
            // foodIdTextBox
            // 
            this.foodIdTextBox.Location = new System.Drawing.Point(309, 39);
            this.foodIdTextBox.Name = "foodIdTextBox";
            this.foodIdTextBox.Size = new System.Drawing.Size(291, 40);
            this.foodIdTextBox.TabIndex = 11;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.categoryLabel.Location = new System.Drawing.Point(18, 273);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(103, 26);
            this.categoryLabel.TabIndex = 10;
            this.categoryLabel.Text = "Category";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(309, 265);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(291, 34);
            this.categoryComboBox.TabIndex = 9;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.priceLabel.Location = new System.Drawing.Point(18, 225);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(63, 26);
            this.priceLabel.TabIndex = 8;
            this.priceLabel.Text = "Price";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(309, 211);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(291, 40);
            this.priceTextBox.TabIndex = 7;
            // 
            // itemLabel
            // 
            this.itemLabel.AutoSize = true;
            this.itemLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.itemLabel.Location = new System.Drawing.Point(18, 165);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(60, 26);
            this.itemLabel.TabIndex = 6;
            this.itemLabel.Text = "Item";
            // 
            // itemTextBox
            // 
            this.itemTextBox.Location = new System.Drawing.Point(309, 151);
            this.itemTextBox.Name = "itemTextBox";
            this.itemTextBox.Size = new System.Drawing.Size(291, 40);
            this.itemTextBox.TabIndex = 5;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.updateButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updateButton.Location = new System.Drawing.Point(357, 314);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(119, 45);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // foodNameLabel
            // 
            this.foodNameLabel.AutoSize = true;
            this.foodNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.foodNameLabel.Location = new System.Drawing.Point(18, 107);
            this.foodNameLabel.Name = "foodNameLabel";
            this.foodNameLabel.Size = new System.Drawing.Size(128, 26);
            this.foodNameLabel.TabIndex = 3;
            this.foodNameLabel.Text = "Food Name";
            // 
            // foodNameTextBox
            // 
            this.foodNameTextBox.Location = new System.Drawing.Point(309, 93);
            this.foodNameTextBox.Name = "foodNameTextBox";
            this.foodNameTextBox.Size = new System.Drawing.Size(291, 40);
            this.foodNameTextBox.TabIndex = 2;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.backButton.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backButton.Location = new System.Drawing.Point(12, 40);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(104, 45);
            this.backButton.TabIndex = 13;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // UpdateFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::The_Magic_Castle.Properties.Resources.pexels_tim_douglas_6210916;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(970, 834);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.updateFoodGroupBox);
            this.Controls.Add(this.foodListGroupBox);
            this.Name = "UpdateFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateFood";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdateFood_FormClosing);
            this.Load += new System.EventHandler(this.UpdateFood_Load);
            this.foodListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.foodListDataGridView)).EndInit();
            this.updateFoodGroupBox.ResumeLayout(false);
            this.updateFoodGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox foodListGroupBox;
        private System.Windows.Forms.DataGridView foodListDataGridView;
        private System.Windows.Forms.GroupBox updateFoodGroupBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label itemLabel;
        private System.Windows.Forms.TextBox itemTextBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label foodNameLabel;
        private System.Windows.Forms.TextBox foodNameTextBox;
        private System.Windows.Forms.Label foodIdLabel;
        private System.Windows.Forms.TextBox foodIdTextBox;
        private System.Windows.Forms.Button backButton;
    }
}