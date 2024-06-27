
namespace The_Magic_Castle.Presentation_Layer
{
    partial class SearchFood
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
            this.backButton = new System.Windows.Forms.Button();
            this.searchFoodGroupBox = new System.Windows.Forms.GroupBox();
            this.searchDataGridView = new System.Windows.Forms.DataGridView();
            this.searchFoodLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.foodListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodListDataGridView)).BeginInit();
            this.searchFoodGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // foodListGroupBox
            // 
            this.foodListGroupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.foodListGroupBox.Controls.Add(this.foodListDataGridView);
            this.foodListGroupBox.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodListGroupBox.Location = new System.Drawing.Point(247, 83);
            this.foodListGroupBox.Name = "foodListGroupBox";
            this.foodListGroupBox.Size = new System.Drawing.Size(638, 361);
            this.foodListGroupBox.TabIndex = 4;
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
            this.foodListDataGridView.Size = new System.Drawing.Size(570, 285);
            this.foodListDataGridView.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(36, 33);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(95, 37);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // searchFoodGroupBox
            // 
            this.searchFoodGroupBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.searchFoodGroupBox.Controls.Add(this.searchTextBox);
            this.searchFoodGroupBox.Controls.Add(this.searchFoodLabel);
            this.searchFoodGroupBox.Controls.Add(this.searchDataGridView);
            this.searchFoodGroupBox.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchFoodGroupBox.Location = new System.Drawing.Point(155, 509);
            this.searchFoodGroupBox.Name = "searchFoodGroupBox";
            this.searchFoodGroupBox.Size = new System.Drawing.Size(825, 313);
            this.searchFoodGroupBox.TabIndex = 6;
            this.searchFoodGroupBox.TabStop = false;
            this.searchFoodGroupBox.Text = "Search Food";
            // 
            // searchDataGridView
            // 
            this.searchDataGridView.AllowUserToAddRows = false;
            this.searchDataGridView.AllowUserToDeleteRows = false;
            this.searchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchDataGridView.Location = new System.Drawing.Point(48, 129);
            this.searchDataGridView.Name = "searchDataGridView";
            this.searchDataGridView.ReadOnly = true;
            this.searchDataGridView.RowHeadersWidth = 51;
            this.searchDataGridView.RowTemplate.Height = 24;
            this.searchDataGridView.Size = new System.Drawing.Size(731, 158);
            this.searchDataGridView.TabIndex = 0;
            // 
            // searchFoodLabel
            // 
            this.searchFoodLabel.AutoSize = true;
            this.searchFoodLabel.Location = new System.Drawing.Point(32, 69);
            this.searchFoodLabel.Name = "searchFoodLabel";
            this.searchFoodLabel.Size = new System.Drawing.Size(151, 31);
            this.searchFoodLabel.TabIndex = 1;
            this.searchFoodLabel.Text = "Food Name";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(299, 66);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(311, 45);
            this.searchTextBox.TabIndex = 2;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // SearchFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::The_Magic_Castle.Properties.Resources.pexels_rajesh_tp_1600727;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1115, 866);
            this.Controls.Add(this.searchFoodGroupBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.foodListGroupBox);
            this.Name = "SearchFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchFood";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchFood_FormClosing);
            this.Load += new System.EventHandler(this.SearchFood_Load);
            this.foodListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.foodListDataGridView)).EndInit();
            this.searchFoodGroupBox.ResumeLayout(false);
            this.searchFoodGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox foodListGroupBox;
        private System.Windows.Forms.DataGridView foodListDataGridView;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.GroupBox searchFoodGroupBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label searchFoodLabel;
        private System.Windows.Forms.DataGridView searchDataGridView;
    }
}