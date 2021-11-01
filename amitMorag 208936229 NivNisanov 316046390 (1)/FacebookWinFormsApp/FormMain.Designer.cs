namespace BasicFacebookFeatures
{
    partial class FormMain
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.generateCommentsButton = new System.Windows.Forms.Button();
            this.musicalEventsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(16, 15);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(239, 28);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(16, 50);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(239, 28);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // generateCommentsButton
            // 
            this.generateCommentsButton.Location = new System.Drawing.Point(34, 133);
            this.generateCommentsButton.Name = "generateCommentsButton";
            this.generateCommentsButton.Size = new System.Drawing.Size(158, 68);
            this.generateCommentsButton.TabIndex = 53;
            this.generateCommentsButton.Text = "generate comments";
            this.generateCommentsButton.UseVisualStyleBackColor = true;
            this.generateCommentsButton.Click += new System.EventHandler(this.generateCommentsButton_Click);
            // 
            // musicalEventsButton
            // 
            this.musicalEventsButton.Location = new System.Drawing.Point(281, 133);
            this.musicalEventsButton.Name = "musicalEventsButton";
            this.musicalEventsButton.Size = new System.Drawing.Size(155, 68);
            this.musicalEventsButton.TabIndex = 54;
            this.musicalEventsButton.Text = "Find Musical Events";
            this.musicalEventsButton.UseVisualStyleBackColor = true;
            this.musicalEventsButton.Click += new System.EventHandler(this.musicalEventsFinderButton_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 647);
            this.Controls.Add(this.musicalEventsButton);
            this.Controls.Add(this.generateCommentsButton);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonLogin);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button generateCommentsButton;
        private System.Windows.Forms.Button musicalEventsButton;
    }
}

