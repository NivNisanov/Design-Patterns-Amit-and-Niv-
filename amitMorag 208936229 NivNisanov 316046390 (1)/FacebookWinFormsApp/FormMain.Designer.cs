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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label countLabel;
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
            this.dataBindingPanel = new System.Windows.Forms.Panel();
            this.membersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.birthdayLabel1 = new System.Windows.Forms.Label();
            this.imageSquarePictureBox = new System.Windows.Forms.PictureBox();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.wallPostsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.albumsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countLabel1 = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            countLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPictures)).BeginInit();
            this.dataBindingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSquarePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallPostsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).BeginInit();
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
            this.birthdaysWishesButton.Click += new System.EventHandler(this.birthdaysWishesButton_Click);
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
            this.friendsListBox.DataSource = this.membersBindingSource;
            this.friendsListBox.FormattingEnabled = true;
            this.friendsListBox.ItemHeight = 16;
            this.friendsListBox.Location = new System.Drawing.Point(633, 38);
            this.friendsListBox.Name = "friendsListBox";
            this.friendsListBox.Size = new System.Drawing.Size(178, 100);
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
            // dataBindingPanel
            // 
            this.dataBindingPanel.BackColor = System.Drawing.SystemColors.Control;
            this.dataBindingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataBindingPanel.Controls.Add(countLabel);
            this.dataBindingPanel.Controls.Add(this.countLabel1);
            this.dataBindingPanel.Controls.Add(birthdayLabel);
            this.dataBindingPanel.Controls.Add(this.birthdayLabel1);
            this.dataBindingPanel.Controls.Add(this.imageSquarePictureBox);
            this.dataBindingPanel.Controls.Add(nameLabel);
            this.dataBindingPanel.Controls.Add(this.nameLabel1);
            this.dataBindingPanel.Location = new System.Drawing.Point(634, 144);
            this.dataBindingPanel.Name = "dataBindingPanel";
            this.dataBindingPanel.Size = new System.Drawing.Size(177, 157);
            this.dataBindingPanel.TabIndex = 61;
            this.dataBindingPanel.Visible = false;
            // 
            // membersBindingSource
            // 
            this.membersBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(3, 102);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(64, 17);
            birthdayLabel.TabIndex = 0;
            birthdayLabel.Text = "Birthday:";
            // 
            // birthdayLabel1
            // 
            this.birthdayLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "Birthday", true));
            this.birthdayLabel1.Location = new System.Drawing.Point(73, 102);
            this.birthdayLabel1.Name = "birthdayLabel1";
            this.birthdayLabel1.Size = new System.Drawing.Size(84, 23);
            this.birthdayLabel1.TabIndex = 1;
            this.birthdayLabel1.Text = "label3";
            // 
            // imageSquarePictureBox
            // 
            this.imageSquarePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.membersBindingSource, "ImageSquare", true));
            this.imageSquarePictureBox.Location = new System.Drawing.Point(3, 3);
            this.imageSquarePictureBox.Name = "imageSquarePictureBox";
            this.imageSquarePictureBox.Size = new System.Drawing.Size(65, 65);
            this.imageSquarePictureBox.TabIndex = 3;
            this.imageSquarePictureBox.TabStop = false;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(3, 77);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(49, 17);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name:";
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "Name", true));
            this.nameLabel1.Location = new System.Drawing.Point(73, 77);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(84, 23);
            this.nameLabel1.TabIndex = 5;
            this.nameLabel1.Text = "label3";
            // 
            // wallPostsBindingSource
            // 
            this.wallPostsBindingSource.DataMember = "WallPosts";
            this.wallPostsBindingSource.DataSource = this.membersBindingSource;
            // 
            // albumsBindingSource
            // 
            this.albumsBindingSource.DataMember = "Albums";
            this.albumsBindingSource.DataSource = this.membersBindingSource;
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Location = new System.Drawing.Point(3, 125);
            countLabel.Name = "countLabel";
            countLabel.Size = new System.Drawing.Size(131, 17);
            countLabel.TabIndex = 5;
            countLabel.Text = "Number Of Albums:";
            // 
            // countLabel1
            // 
            this.countLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumsBindingSource, "Count", true));
            this.countLabel1.Location = new System.Drawing.Point(129, 125);
            this.countLabel1.Name = "countLabel1";
            this.countLabel1.Size = new System.Drawing.Size(49, 23);
            this.countLabel1.TabIndex = 6;
            this.countLabel1.Text = "label3";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(818, 534);
            this.Controls.Add(this.dataBindingPanel);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook App";
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPictures)).EndInit();
            this.dataBindingPanel.ResumeLayout(false);
            this.dataBindingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSquarePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallPostsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).EndInit();
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
        private System.Windows.Forms.Panel dataBindingPanel;
        private System.Windows.Forms.BindingSource membersBindingSource;
        private System.Windows.Forms.Label birthdayLabel1;
        private System.Windows.Forms.PictureBox imageSquarePictureBox;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.BindingSource wallPostsBindingSource;
        private System.Windows.Forms.Label countLabel1;
        private System.Windows.Forms.BindingSource albumsBindingSource;
    }
}

