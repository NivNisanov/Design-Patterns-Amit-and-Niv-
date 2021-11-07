using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Text.RegularExpressions;

namespace BasicFacebookFeatures
{
    public partial class FormGenerateComment : Form
    {
        private readonly User r_LoggedInUser;
        private readonly CommentGenerator r_CommentGenerator;

        public FormGenerateComment(User i_LoggedInUser)
        {
            InitializeComponent();
            r_LoggedInUser = i_LoggedInUser;
            r_CommentGenerator = new CommentGenerator();
            profilePictureBox.LoadAsync(r_LoggedInUser.PictureNormalURL);
            fetchPosts();
        }

        private void profilePictureLable_Click(object sender, EventArgs e)
        {

        }

        private void fetchPosts()
        {
            //all posts
            PopulateListBoxOfType(r_LoggedInUser.Posts, commentsListBox);
        }

        private void filterOnlyBirthdayPosts()
        {
            List<Post> birthdayPosts = new List<Post>();
            Regex englishBirthdayMessageRegex = new Regex("[Bb][Ii][rR][tT][hH][dD][aA][yY]");
            Regex hebrewBirthdayMessageRegex = new Regex("מזל טוב");
            foreach (object item in commentsListBox.Items)
            {
                if (item is Post post)
                {
                    if (!string.IsNullOrEmpty(post.Message) && (hebrewBirthdayMessageRegex.IsMatch(post.Message) || englishBirthdayMessageRegex.IsMatch(post.Message)))
                    {
                        birthdayPosts.Add(post);
                    }
                }
            }

            PopulateListBoxOfType(birthdayPosts, commentsListBox);
        }

        protected void PopulateListBoxOfType<T>(IEnumerable<T> i_Items, ListBox i_ListBox)
        {
            i_ListBox.Items.Clear();

            foreach (T item in i_Items)
            {
                i_ListBox.Items.Add(item);
            }
        }
        private void displaySuggestedComments()
        {
            foreach (object item in commentsListBox.Items)
            {
                if (item is Post birthdayPost)
                {
                    string replyMessage = r_CommentGenerator.GenerateText(birthdayPost.From);
                    suggestedCommentsLst.Items.Add(replyMessage);
                }
            }
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            generateBirthdayComment.Visible = true;
            filterOnlyBirthdayPosts();
        }

        private void generateBirthdayComment_click(object sender, EventArgs e)
        {
            suggestedCommentsLst.Visible = true;
            displaySuggestedComments();
        }
    }
}
