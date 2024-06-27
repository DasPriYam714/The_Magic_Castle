
namespace The_Magic_Castle.Presentation_Layer
{
    partial class SearchManager
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
            this.managerListGroupBox = new System.Windows.Forms.GroupBox();
            this.managerListDataGridView = new System.Windows.Forms.DataGridView();
            this.searchManagerGroupBox = new System.Windows.Forms.GroupBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchManagerLabel = new System.Windows.Forms.Label();
            this.searchManagerDataGridView = new System.Windows.Forms.DataGridView();
            this.backButton = new System.Windows.Forms.Button();
            this.managerListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.managerListDataGridView)).BeginInit();
            this.searchManagerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchManagerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // managerListGroupBox
            // 
            this.managerListGroupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.managerListGroupBox.Controls.Add(this.managerListDataGridView);
            this.managerListGroupBox.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerListGroupBox.Location = new System.Drawing.Point(257, 87);
            this.managerListGroupBox.Name = "managerListGroupBox";
            this.managerListGroupBox.Size = new System.Drawing.Size(610, 368);
            this.managerListGroupBox.TabIndex = 1;
            this.managerListGroupBox.TabStop = false;
            this.managerListGroupBox.Text = "Manager List";
            // 
            // managerListDataGridView
            // 
            this.managerListDataGridView.AllowUserToAddRows = false;
            this.managerListDataGridView.AllowUserToDeleteRows = false;
            this.managerListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.managerListDataGridView.Location = new System.Drawing.Point(27, 39);
            this.managerListDataGridView.Name = "managerListDataGridView";
            this.managerListDataGridView.ReadOnly = true;
            this.managerListDataGridView.RowHeadersWidth = 51;
            this.managerListDataGridView.RowTemplate.Height = 24;
            this.managerListDataGridView.Size = new System.Drawing.Size(552, 303);
            this.managerListDataGridView.TabIndex = 0;
            // 
            // searchManagerGroupBox
            // 
            this.searchManagerGroupBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.searchManagerGroupBox.Controls.Add(this.searchTextBox);
            this.searchManagerGroupBox.Controls.Add(this.searchManagerLabel);
            this.searchManagerGroupBox.Controls.Add(this.searchManagerDataGridView);
            this.searchManagerGroupBox.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchManagerGroupBox.Location = new System.Drawing.Point(147, 511);
            this.searchManagerGroupBox.Name = "searchManagerGroupBox";
            this.searchManagerGroupBox.Size = new System.Drawing.Size(825, 313);
            this.searchManagerGroupBox.TabIndex = 7;
            this.searchManagerGroupBox.TabStop = false;
            this.searchManagerGroupBox.Text = "Search Manager";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(299, 66);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(311, 45);
            this.searchTextBox.TabIndex = 2;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // searchManagerLabel
            // 
            this.searchManagerLabel.AutoSize = true;
            this.searchManagerLabel.Location = new System.Drawing.Point(32, 69);
            this.searchManagerLabel.Name = "searchManagerLabel";
            this.searchManagerLabel.Size = new System.Drawing.Size(129, 31);
            this.searchManagerLabel.TabIndex = 1;
            this.searchManagerLabel.Text = "Username";
            // 
            // searchManagerDataGridView
            // 
            this.searchManagerDataGridView.AllowUserToAddRows = false;
            this.searchManagerDataGridView.AllowUserToDeleteRows = false;
            this.searchManagerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchManagerDataGridView.Location = new System.Drawing.Point(48, 129);
            this.searchManagerDataGridView.Name = "searchManagerDataGridView";
            this.searchManagerDataGridView.ReadOnly = true;
            this.searchManagerDataGridView.RowHeadersWidth = 51;
            this.searchManagerDataGridView.RowTemplate.Height = 24;
            this.searchManagerDataGridView.Size = new System.Drawing.Size(731, 158);
            this.searchManagerDataGridView.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(27, 48);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(94, 39);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // SearchManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::The_Magic_Castle.Properties.Resources._542932582bc05_thumb900;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1087, 845);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.searchManagerGroupBox);
            this.Controls.Add(this.managerListGroupBox);
            this.Name = "SearchManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchManager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchManager_FormClosing);
            this.Load += new System.EventHandler(this.SearchManager_Load);
            this.managerListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.managerListDataGridView)).EndInit();
            this.searchManagerGroupBox.ResumeLayout(false);
            this.searchManagerGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchManagerDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox managerListGroupBox;
        private System.Windows.Forms.DataGridView managerListDataGridView;
        private System.Windows.Forms.GroupBox searchManagerGroupBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label searchManagerLabel;
        private System.Windows.Forms.DataGridView searchManagerDataGridView;
        private System.Windows.Forms.Button backButton;
    }
}