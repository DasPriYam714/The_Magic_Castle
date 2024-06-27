
namespace The_Magic_Castle.Presentation_Layer
{
    partial class Manager_Info
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
            this.addManagerbutton = new System.Windows.Forms.Button();
            this.removeManagerButton = new System.Windows.Forms.Button();
            this.updateManagerButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.managerListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.managerListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // managerListGroupBox
            // 
            this.managerListGroupBox.Controls.Add(this.managerListDataGridView);
            this.managerListGroupBox.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerListGroupBox.Location = new System.Drawing.Point(256, 59);
            this.managerListGroupBox.Name = "managerListGroupBox";
            this.managerListGroupBox.Size = new System.Drawing.Size(532, 368);
            this.managerListGroupBox.TabIndex = 0;
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
            this.managerListDataGridView.Size = new System.Drawing.Size(477, 303);
            this.managerListDataGridView.TabIndex = 0;
            // 
            // addManagerbutton
            // 
            this.addManagerbutton.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addManagerbutton.Location = new System.Drawing.Point(67, 540);
            this.addManagerbutton.Name = "addManagerbutton";
            this.addManagerbutton.Size = new System.Drawing.Size(122, 82);
            this.addManagerbutton.TabIndex = 1;
            this.addManagerbutton.Text = "Add Manager";
            this.addManagerbutton.UseVisualStyleBackColor = true;
            this.addManagerbutton.Click += new System.EventHandler(this.addManagerbutton_Click);
            // 
            // removeManagerButton
            // 
            this.removeManagerButton.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeManagerButton.Location = new System.Drawing.Point(300, 540);
            this.removeManagerButton.Name = "removeManagerButton";
            this.removeManagerButton.Size = new System.Drawing.Size(122, 82);
            this.removeManagerButton.TabIndex = 2;
            this.removeManagerButton.Text = "Remove Manager";
            this.removeManagerButton.UseVisualStyleBackColor = true;
            this.removeManagerButton.Click += new System.EventHandler(this.removeManagerButton_Click);
            // 
            // updateManagerButton
            // 
            this.updateManagerButton.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateManagerButton.Location = new System.Drawing.Point(831, 540);
            this.updateManagerButton.Name = "updateManagerButton";
            this.updateManagerButton.Size = new System.Drawing.Size(122, 82);
            this.updateManagerButton.TabIndex = 3;
            this.updateManagerButton.Text = "Update Manager";
            this.updateManagerButton.UseVisualStyleBackColor = true;
            this.updateManagerButton.Click += new System.EventHandler(this.updateManagerButton_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(12, 30);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 32);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(568, 540);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(122, 82);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search Manager";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // Manager_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::The_Magic_Castle.Properties.Resources.pexels_live_on_shot_2788792;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1020, 729);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.updateManagerButton);
            this.Controls.Add(this.removeManagerButton);
            this.Controls.Add(this.addManagerbutton);
            this.Controls.Add(this.managerListGroupBox);
            this.Name = "Manager_Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager_Info";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Manager_Info_FormClosing);
            this.Load += new System.EventHandler(this.Manager_Info_Load);
            this.managerListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.managerListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox managerListGroupBox;
        private System.Windows.Forms.DataGridView managerListDataGridView;
        private System.Windows.Forms.Button addManagerbutton;
        private System.Windows.Forms.Button removeManagerButton;
        private System.Windows.Forms.Button updateManagerButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button searchButton;
    }
}