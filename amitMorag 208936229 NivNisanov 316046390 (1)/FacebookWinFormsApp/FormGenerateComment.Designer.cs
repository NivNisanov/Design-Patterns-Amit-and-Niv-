
namespace BasicFacebookFeatures
{
    partial class FormGenerateComment
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
            this.birthDayLabel = new System.Windows.Forms.Label();
            this.filterButton = new System.Windows.Forms.Button();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.commentsListBox = new System.Windows.Forms.ListBox();
            this.generateBirthdayComment = new System.Windows.Forms.Button();
            this.suggestedCommentsLst = new System.Windows.Forms.ListBox();
            this.coverPic = new System.Windows.Forms.PictureBox();
            this.commentSuggestionLable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverPic)).BeginInit();
            this.SuspendLayout();
            // 
            // birthDayLabel
            // 
            this.birthDayLabel.AutoSize = true;
            this.birthDayLabel.Location = new System.Drawing.Point(9, 245);
            this.birthDayLabel.Name = "birthDayLabel";
            this.birthDayLabel.Size = new System.Drawing.Size(126, 17);
            this.birthDayLabel.TabIndex = 0;
            this.birthDayLabel.Text = "Posts on your wall:";
            this.birthDayLabel.Click += new System.EventHandler(this.profilePictureLable_Click);
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(12, 407);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(313, 32);
            this.filterButton.TabIndex = 1;
            this.filterButton.Text = "filterOnlyBirthdayPosts";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Location = new System.Drawing.Point(25, 27);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Padding = new System.Windows.Forms.Padding(5);
            this.profilePictureBox.Size = new System.Drawing.Size(110, 110);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePictureBox.TabIndex = 2;
            this.profilePictureBox.TabStop = false;
            // 
            // commentsListBox
            // 
            this.commentsListBox.FormattingEnabled = true;
            this.commentsListBox.ItemHeight = 16;
            this.commentsListBox.Location = new System.Drawing.Point(12, 269);
            this.commentsListBox.Name = "commentsListBox";
            this.commentsListBox.Size = new System.Drawing.Size(313, 132);
            this.commentsListBox.TabIndex = 3;
            // 
            // generateBirthdayComment
            // 
            this.generateBirthdayComment.Location = new System.Drawing.Point(347, 407);
            this.generateBirthdayComment.Name = "generateBirthdayComment";
            this.generateBirthdayComment.Size = new System.Drawing.Size(237, 32);
            this.generateBirthdayComment.TabIndex = 4;
            this.generateBirthdayComment.Text = "generateBirthdayComment";
            this.generateBirthdayComment.UseVisualStyleBackColor = true;
            this.generateBirthdayComment.Visible = false;
            this.generateBirthdayComment.Click += new System.EventHandler(this.generateBirthdayComment_click);
            // 
            // suggestedCommentsLst
            // 
            this.suggestedCommentsLst.FormattingEnabled = true;
            this.suggestedCommentsLst.ItemHeight = 16;
            this.suggestedCommentsLst.Location = new System.Drawing.Point(347, 269);
            this.suggestedCommentsLst.Name = "suggestedCommentsLst";
            this.suggestedCommentsLst.Size = new System.Drawing.Size(237, 132);
            this.suggestedCommentsLst.TabIndex = 5;
            this.suggestedCommentsLst.Visible = false;
            // 
            // coverPic
            // 
            this.coverPic.Location = new System.Drawing.Point(12, 12);
            this.coverPic.Name = "coverPic";
            this.coverPic.Size = new System.Drawing.Size(572, 221);
            this.coverPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coverPic.TabIndex = 6;
            this.coverPic.TabStop = false;
            // 
            // commentSuggestionLable
            // 
            this.commentSuggestionLable.AutoSize = true;
            this.commentSuggestionLable.Location = new System.Drawing.Point(344, 245);
            this.commentSuggestionLable.Name = "commentSuggestionLable";
            this.commentSuggestionLable.Size = new System.Drawing.Size(159, 17);
            this.commentSuggestionLable.TabIndex = 7;
            this.commentSuggestionLable.Text = "Comments suggeations:";
            this.commentSuggestionLable.Visible = false;
            this.commentSuggestionLable.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormGenerateComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 448);
            this.Controls.Add(this.commentSuggestionLable);
            this.Controls.Add(this.suggestedCommentsLst);
            this.Controls.Add(this.generateBirthdayComment);
            this.Controls.Add(this.commentsListBox);
            this.Controls.Add(this.profilePictureBox);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.birthDayLabel);
            this.Controls.Add(this.coverPic);
            this.Name = "FormGenerateComment";
            this.Text = "Form Generate Commen";
            this.Load += new System.EventHandler(this.FormGenerateComment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label birthDayLabel;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.ListBox commentsListBox;
        private System.Windows.Forms.Button generateBirthdayComment;
        private System.Windows.Forms.ListBox suggestedCommentsLst;
        private System.Windows.Forms.PictureBox coverPic;
        private System.Windows.Forms.Label commentSuggestionLable;
    }
}