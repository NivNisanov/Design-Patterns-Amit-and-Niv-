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
using System.Threading;

namespace BasicFacebookFeatures
{
    public partial class FormGenerateComment : Form
    {
        private readonly User r_LoggedInUser;
        private readonly CommentGenerator r_CommentGenerator;

        public FormGenerateComment()
        {
            InitializeComponent();
            r_LoggedInUser = FormMain.Instance.LoggedInUser;
            r_CommentGenerator = new CommentGenerator();
            profilePictureBox.Image = r_LoggedInUser.ImageSquare;
            if (r_LoggedInUser.Albums[1].Photos[0] != null)
            {
                coverPic.Image = r_LoggedInUser.Albums[1].Photos[0].ImageNormal;
            }
            else
            {
                coverPic.ForeColor = Color.DodgerBlue;
            }

            new Thread(fetchPosts).Start();
            //fetchPosts();
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
            i_ListBox.Invoke(new Action(() => i_ListBox.Items.Clear()));

            foreach (T item in i_Items)
            {
                i_ListBox.Invoke(new Action(() => i_ListBox.Items.Add(item)));
            }
        }
        private void displaySuggestedComments()
        {
            foreach (object item in commentsListBox.Items)
            {
                if (item is Post birthdayPost)
                {
                    User author = birthdayPost.From;
                    string birthday = null;
                    if(author != null)
                    {
                        birthday = author.Birthday;
                    }
                    string replyMessage = r_CommentGenerator.GenerateText(author, birthday);
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
            commentSuggestionLable.Visible = true;
            displaySuggestedComments();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormGenerateComment_Load(object sender, EventArgs e)
        {

        }
    }
}
