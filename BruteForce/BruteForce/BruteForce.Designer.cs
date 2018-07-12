namespace BruteForce
{
    partial class BruteForce
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BruteForce));
            this.BruteForceButton = new System.Windows.Forms.Button();
            this.welcome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Loading = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BruteForceButton
            // 
            this.BruteForceButton.BackColor = System.Drawing.Color.White;
            this.BruteForceButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BruteForceButton.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BruteForceButton.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.BruteForceButton.Location = new System.Drawing.Point(41, 100);
            this.BruteForceButton.Name = "BruteForceButton";
            this.BruteForceButton.Size = new System.Drawing.Size(69, 23);
            this.BruteForceButton.TabIndex = 0;
            this.BruteForceButton.Text = "Enter";
            this.BruteForceButton.UseVisualStyleBackColor = false;
            this.BruteForceButton.Click += new System.EventHandler(this.BruteForceButton_Click);
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.BackColor = System.Drawing.SystemColors.Menu;
            this.welcome.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.welcome.Location = new System.Drawing.Point(95, 0);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(103, 33);
            this.welcome.TabIndex = 1;
            this.welcome.Text = "Welcome!";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("High Tower Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 65);
            this.label2.TabIndex = 2;
            this.label2.Text = "To enter the site using brute force, please push the button below:";
            // 
            // Loading
            // 
            this.Loading.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Loading.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loading.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Loading.Location = new System.Drawing.Point(232, 33);
            this.Loading.Name = "Loading";
            this.Loading.Size = new System.Drawing.Size(55, 41);
            this.Loading.TabIndex = 3;
            this.Loading.Text = "Please Wait...";
            this.Loading.Visible = false;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.Sienna;
            this.password.Location = new System.Drawing.Point(151, 69);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(108, 15);
            this.password.TabIndex = 4;
            this.password.Text = "The password is: ";
            this.password.Visible = false;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.DimGray;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.Location = new System.Drawing.Point(267, 9);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(20, 21);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.Text = "\r\n";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Visible = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // BruteForce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(299, 131);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.password);
            this.Controls.Add(this.Loading);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.BruteForceButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BruteForce";
            this.Text = "Brute Force";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BruteForceButton;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label Loading;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Button CloseButton;
    }
}

