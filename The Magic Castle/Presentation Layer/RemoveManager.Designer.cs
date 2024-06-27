
namespace The_Magic_Castle.Presentation_Layer
{
    partial class RemoveManager
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
            this.managerGroupBox = new System.Windows.Forms.GroupBox();
            this.managerListDataGridView = new System.Windows.Forms.DataGridView();
            this.deleteCategorygroupBox = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.manIdlabel = new System.Windows.Forms.Label();
            this.deleteManIdTextBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.managerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.managerListDataGridView)).BeginInit();
            this.deleteCategorygroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // managerGroupBox
            // 
            this.managerGroupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.managerGroupBox.Controls.Add(this.managerListDataGridView);
            this.managerGroupBox.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerGroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.managerGroupBox.Location = new System.Drawing.Point(281, 63);
            this.managerGroupBox.Name = "managerGroupBox";
            this.managerGroupBox.Size = new System.Drawing.Size(456, 285);
            this.managerGroupBox.TabIndex = 2;
            this.managerGroupBox.TabStop = false;
            this.managerGroupBox.Text = "Manager List";
            // 
            // managerListDataGridView
            // 
            this.managerListDataGridView.AllowUserToAddRows = false;
            this.managerListDataGridView.AllowUserToDeleteRows = false;
            this.managerListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.managerListDataGridView.Location = new System.Drawing.Point(23, 51);
            this.managerListDataGridView.Name = "managerListDataGridView";
            this.managerListDataGridView.ReadOnly = true;
            this.managerListDataGridView.RowHeadersWidth = 51;
            this.managerListDataGridView.RowTemplate.Height = 24;
            this.managerListDataGridView.Size = new System.Drawing.Size(412, 203);
            this.managerListDataGridView.TabIndex = 3;
            this.managerListDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.managerListDataGridView_CellClick);
            // 
            // deleteCategorygroupBox
            // 
            this.deleteCategorygroupBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.deleteCategorygroupBox.Controls.Add(this.deleteButton);
            this.deleteCategorygroupBox.Controls.Add(this.manIdlabel);
            this.deleteCategorygroupBox.Controls.Add(this.deleteManIdTextBox);
            this.deleteCategorygroupBox.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCategorygroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deleteCategorygroupBox.Location = new System.Drawing.Point(244, 518);
            this.deleteCategorygroupBox.Name = "deleteCategorygroupBox";
            this.deleteCategorygroupBox.Size = new System.Drawing.Size(573, 194);
            this.deleteCategorygroupBox.TabIndex = 6;
            this.deleteCategorygroupBox.TabStop = false;
            this.deleteCategorygroupBox.Text = "Remove Manager";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deleteButton.Location = new System.Drawing.Point(240, 119);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(111, 44);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Remove";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // manIdlabel
            // 
            this.manIdlabel.AutoSize = true;
            this.manIdlabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.manIdlabel.Location = new System.Drawing.Point(6, 77);
            this.manIdlabel.Name = "manIdlabel";
            this.manIdlabel.Size = new System.Drawing.Size(127, 26);
            this.manIdlabel.TabIndex = 3;
            this.manIdlabel.Text = "Manager Id";
            // 
            // deleteManIdTextBox
            // 
            this.deleteManIdTextBox.Location = new System.Drawing.Point(177, 63);
            this.deleteManIdTextBox.Name = "deleteManIdTextBox";
            this.deleteManIdTextBox.Size = new System.Drawing.Size(254, 40);
            this.deleteManIdTextBox.TabIndex = 2;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.backButton.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backButton.Location = new System.Drawing.Point(21, 27);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(111, 44);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // RemoveManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::The_Magic_Castle.Properties.Resources.pexels_engin_akyurt_2673353;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1001, 786);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.deleteCategorygroupBox);
            this.Controls.Add(this.managerGroupBox);
            this.Name = "RemoveManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemoveManager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RemoveManager_FormClosing);
            this.Load += new System.EventHandler(this.RemoveManager_Load);
            this.managerGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.managerListDataGridView)).EndInit();
            this.deleteCategorygroupBox.ResumeLayout(false);
            this.deleteCategorygroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox managerGroupBox;
        private System.Windows.Forms.DataGridView managerListDataGridView;
        private System.Windows.Forms.GroupBox deleteCategorygroupBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label manIdlabel;
        private System.Windows.Forms.TextBox deleteManIdTextBox;
        private System.Windows.Forms.Button backButton;
    }
}