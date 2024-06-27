
namespace The_Magic_Castle.Presentation_Layer
{
    partial class TMC_Homepage
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
            this.loginButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.contuctButton = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.resLabel = new System.Windows.Forms.Label();
            this.welLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.loginButton.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.loginButton.Location = new System.Drawing.Point(134, 12);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(167, 63);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.aboutButton.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.aboutButton.Location = new System.Drawing.Point(470, 13);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(167, 63);
            this.aboutButton.TabIndex = 1;
            this.aboutButton.Text = "About Us";
            this.aboutButton.UseVisualStyleBackColor = false;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // contuctButton
            // 
            this.contuctButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.contuctButton.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contuctButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.contuctButton.Location = new System.Drawing.Point(796, 14);
            this.contuctButton.Name = "contuctButton";
            this.contuctButton.Size = new System.Drawing.Size(170, 63);
            this.contuctButton.TabIndex = 2;
            this.contuctButton.Text = "Contuct Us";
            this.contuctButton.UseVisualStyleBackColor = false;
            this.contuctButton.Click += new System.EventHandler(this.contuctButton_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BackColor = System.Drawing.Color.Silver;
            this.welcomeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.welcomeLabel.Font = new System.Drawing.Font("Old English Text MT", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.Teal;
            this.welcomeLabel.Location = new System.Drawing.Point(151, 459);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(954, 145);
            this.welcomeLabel.TabIndex = 3;
            this.welcomeLabel.Text = "The Magic Castle";
            // 
            // resLabel
            // 
            this.resLabel.AutoSize = true;
            this.resLabel.BackColor = System.Drawing.Color.Silver;
            this.resLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resLabel.Font = new System.Drawing.Font("Old English Text MT", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resLabel.ForeColor = System.Drawing.Color.Teal;
            this.resLabel.Location = new System.Drawing.Point(388, 577);
            this.resLabel.Name = "resLabel";
            this.resLabel.Size = new System.Drawing.Size(411, 97);
            this.resLabel.TabIndex = 4;
            this.resLabel.Text = "Restaurant";
            // 
            // welLabel
            // 
            this.welLabel.AutoSize = true;
            this.welLabel.BackColor = System.Drawing.Color.RosyBrown;
            this.welLabel.Font = new System.Drawing.Font("ScriptC", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.welLabel.Location = new System.Drawing.Point(417, 321);
            this.welLabel.Name = "welLabel";
            this.welLabel.Size = new System.Drawing.Size(344, 96);
            this.welLabel.TabIndex = 5;
            this.welLabel.Text = "Welcome to";
            // 
            // TMC_Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::The_Magic_Castle.Properties.Resources._2017_06_29_MagicCastle_020;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 703);
            this.Controls.Add(this.welLabel);
            this.Controls.Add(this.resLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.contuctButton);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.loginButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TMC_Homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TMC_Homepage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TMC_Homepage_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button contuctButton;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label resLabel;
        private System.Windows.Forms.Label welLabel;
    }
}