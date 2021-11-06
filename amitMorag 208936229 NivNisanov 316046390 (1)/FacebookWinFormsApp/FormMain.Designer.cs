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
            this.birthdaysWishesButton = new System.Windows.Forms.Button();
            this.profilePic = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(197, 163);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(239, 61);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(526, 264);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(93, 37);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Visible = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // generateCommentsButton
            // 
            this.generateCommentsButton.Location = new System.Drawing.Point(11, 326);
            this.generateCommentsButton.Name = "generateCommentsButton";
            this.generateCommentsButton.Size = new System.Drawing.Size(295, 68);
            this.generateCommentsButton.TabIndex = 53;
            this.generateCommentsButton.Text = "Generate Comments For Happy Birthday Posts On Your Wall";
            this.generateCommentsButton.UseVisualStyleBackColor = true;
            this.generateCommentsButton.Visible = false;
            this.generateCommentsButton.Click += new System.EventHandler(this.generateCommentsButton_Click);
            // 
            // birthdaysWishesButton
            // 
            this.birthdaysWishesButton.Location = new System.Drawing.Point(324, 326);
            this.birthdaysWishesButton.Name = "birthdaysWishesButton";
            this.birthdaysWishesButton.Size = new System.Drawing.Size(295, 68);
            this.birthdaysWishesButton.TabIndex = 54;
            this.birthdaysWishesButton.Text = "Find And Prepare Birthday Wishes";
            this.birthdaysWishesButton.UseVisualStyleBackColor = true;
            this.birthdaysWishesButton.Visible = false;
            this.birthdaysWishesButton.Click += new System.EventHandler(this.musicalEventsFinderButton_Click);
            // 
            // profilePic
            // 
            this.profilePic.BackColor = System.Drawing.Color.White;
            this.profilePic.Location = new System.Drawing.Point(25, 26);
            this.profilePic.Name = "profilePic";
            this.profilePic.Padding = new System.Windows.Forms.Padding(5);
            this.profilePic.Size = new System.Drawing.Size(90, 90);
            this.profilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePic.TabIndex = 55;
            this.profilePic.TabStop = false;
            this.profilePic.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(607, 245);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 406);
            this.Controls.Add(this.profilePic);
            this.Controls.Add(this.birthdaysWishesButton);
            this.Controls.Add(this.generateCommentsButton);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook App";
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button generateCommentsButton;
        private System.Windows.Forms.Button birthdaysWishesButton;
        private System.Windows.Forms.PictureBox profilePic;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

