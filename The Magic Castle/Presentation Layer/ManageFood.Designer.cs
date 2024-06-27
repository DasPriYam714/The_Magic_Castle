
namespace The_Magic_Castle.Presentation_Layer
{
    partial class ManageFood
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
            this.addDeleteButton = new System.Windows.Forms.Button();
            this.updateFoodButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.foodListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // foodListGroupBox
            // 
            this.foodListGroupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.foodListGroupBox.Controls.Add(this.foodListDataGridView);
            this.foodListGroupBox.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodListGroupBox.Location = new System.Drawing.Point(222, 49);
            this.foodListGroupBox.Name = "foodListGroupBox";
            this.foodListGroupBox.Size = new System.Drawing.Size(524, 361);
            this.foodListGroupBox.TabIndex = 0;
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
            this.foodListDataGridView.Size = new System.Drawing.Size(453, 285);
            this.foodListDataGridView.TabIndex = 0;
            // 
            // addDeleteButton
            // 
            this.addDeleteButton.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDeleteButton.Location = new System.Drawing.Point(73, 473);
            this.addDeleteButton.Name = "addDeleteButton";
            this.addDeleteButton.Size = new System.Drawing.Size(153, 74);
            this.addDeleteButton.TabIndex = 1;
            this.addDeleteButton.Text = "Add/Delete Food";
            this.addDeleteButton.UseVisualStyleBackColor = true;
            this.addDeleteButton.Click += new System.EventHandler(this.addDeleteButton_Click);
            // 
            // updateFoodButton
            // 
            this.updateFoodButton.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateFoodButton.Location = new System.Drawing.Point(740, 473);
            this.updateFoodButton.Name = "updateFoodButton";
            this.updateFoodButton.Size = new System.Drawing.Size(149, 74);
            this.updateFoodButton.TabIndex = 2;
            this.updateFoodButton.Text = "Update Food";
            this.updateFoodButton.UseVisualStyleBackColor = true;
            this.updateFoodButton.Click += new System.EventHandler(this.updateFoodButton_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(36, 33);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(93, 34);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ManageFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::The_Magic_Castle.Properties.Resources.pexels_chan_walrus_958545;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(955, 693);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.updateFoodButton);
            this.Controls.Add(this.addDeleteButton);
            this.Controls.Add(this.foodListGroupBox);
            this.Name = "ManageFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageFood";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageFood_FormClosing);
            this.Load += new System.EventHandler(this.ManageFood_Load);
            this.foodListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.foodListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox foodListGroupBox;
        private System.Windows.Forms.DataGridView foodListDataGridView;
        private System.Windows.Forms.Button addDeleteButton;
        private System.Windows.Forms.Button updateFoodButton;
        private System.Windows.Forms.Button backButton;
    }
}