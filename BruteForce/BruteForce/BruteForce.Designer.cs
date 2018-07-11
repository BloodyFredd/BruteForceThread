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
            this.BruteForceButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Loading = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BruteForceButton
            // 
            this.BruteForceButton.Location = new System.Drawing.Point(142, 93);
            this.BruteForceButton.Name = "BruteForceButton";
            this.BruteForceButton.Size = new System.Drawing.Size(46, 23);
            this.BruteForceButton.TabIndex = 0;
            this.BruteForceButton.Text = "Enter";
            this.BruteForceButton.UseVisualStyleBackColor = true;
            this.BruteForceButton.Click += new System.EventHandler(this.BruteForceButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome!";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "To enter the site using brute force, please push the button below:";
            // 
            // Loading
            // 
            this.Loading.AutoSize = true;
            this.Loading.Location = new System.Drawing.Point(12, 65);
            this.Loading.Name = "Loading";
            this.Loading.Size = new System.Drawing.Size(73, 13);
            this.Loading.TabIndex = 3;
            this.Loading.Text = "Please Wait...";
            this.Loading.Visible = false;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(12, 98);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(90, 13);
            this.password.TabIndex = 4;
            this.password.Text = "The password is: ";
            this.password.Visible = false;
            // 
            // BruteForce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 125);
            this.Controls.Add(this.password);
            this.Controls.Add(this.Loading);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BruteForceButton);
            this.Name = "BruteForce";
            this.Text = "Brute Force";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BruteForceButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label Loading;
        private System.Windows.Forms.Label password;
    }
}

