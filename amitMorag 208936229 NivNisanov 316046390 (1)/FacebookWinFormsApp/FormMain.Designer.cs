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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.userPictures = new System.Windows.Forms.PictureBox();
            this.friendsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPictures)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(190, 189);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(429, 159);
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
            this.generateCommentsButton.Location = new System.Drawing.Point(12, 454);
            this.generateCommentsButton.Name = "generateCommentsButton";
            this.generateCommentsButton.Size = new System.Drawing.Size(390, 68);
            this.generateCommentsButton.TabIndex = 53;
            this.generateCommentsButton.Text = "Generate Comments For Happy Birthday Posts On Your Wall";
            this.generateCommentsButton.UseVisualStyleBackColor = true;
            this.generateCommentsButton.Visible = false;
            this.generateCommentsButton.Click += new System.EventHandler(this.generateCommentsButton_Click);
            // 
            // birthdaysWishesButton
            // 
            this.birthdaysWishesButton.Location = new System.Drawing.Point(423, 454);
            this.birthdaysWishesButton.Name = "birthdaysWishesButton";
            this.birthdaysWishesButton.Size = new System.Drawing.Size(390, 68);
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // userPictures
            // 
            this.userPictures.BackColor = System.Drawing.Color.White;
            this.userPictures.Location = new System.Drawing.Point(-7, 310);
            this.userPictures.Name = "userPictures";
            this.userPictures.Size = new System.Drawing.Size(842, 133);
            this.userPictures.TabIndex = 57;
            this.userPictures.TabStop = false;
            this.userPictures.Visible = false;
            // 
            // friendsListBox
            // 
            this.friendsListBox.FormattingEnabled = true;
            this.friendsListBox.ItemHeight = 16;
            this.friendsListBox.Location = new System.Drawing.Point(633, 38);
            this.friendsListBox.Name = "friendsListBox";
            this.friendsListBox.Size = new System.Drawing.Size(178, 260);
            this.friendsListBox.TabIndex = 58;
            this.friendsListBox.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(631, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 59;
            this.label1.Text = "Friends:";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 60;
            this.label2.Text = "Photos:";
            this.label2.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 534);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.friendsListBox);
            this.Controls.Add(this.profilePic);
            this.Controls.Add(this.birthdaysWishesButton);
            this.Controls.Add(this.generateCommentsButton);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.userPictures);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook App";
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPictures)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button generateCommentsButton;
        private System.Windows.Forms.Button birthdaysWishesButton;
        private System.Windows.Forms.PictureBox profilePic;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox userPictures;
        private System.Windows.Forms.ListBox friendsListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

