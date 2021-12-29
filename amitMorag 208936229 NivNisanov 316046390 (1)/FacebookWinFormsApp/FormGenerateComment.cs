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
        private readonly FacebookAppLogicFacade r_AppLogicFacade;
        private List<Post> m_FilteredPosts;

        public FormGenerateComment()
        {
            InitializeComponent();
            r_LoggedInUser = FormMain.Instance.LoggedInUser;         
            r_AppLogicFacade = new FacebookAppLogicFacade();
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
        }

        private void profilePictureLable_Click(object sender, EventArgs e)
        {

        }

        private void fetchPosts()
        {
            //all posts
            List<Post> allPosts = r_AppLogicFacade.GetAllPosts();
            PopulateListBoxOfType(allPosts, commentsListBox);
        }
        
        protected void PopulateListBoxOfType<T>(IEnumerable<T> i_Items, ListBox i_ListBox)
        {
            i_ListBox.Invoke(new Action(() => i_ListBox.Items.Clear()));

            foreach (T item in i_Items)
            {
                i_ListBox.Invoke(new Action(() => i_ListBox.Items.Add(item)));
            }
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            generateBirthdayComment.Visible = true;
            m_FilteredPosts = r_AppLogicFacade.FilterOnlyBirthdayPosts(commentsListBox.Items.Cast<Post>().ToList());
            PopulateListBoxOfType(m_FilteredPosts, commentsListBox);
        }

        private void generateBirthdayComment_click(object sender, EventArgs e)
        {
            suggestedCommentsLst.Visible = true;
            commentSuggestionLable.Visible = true;
            List<string> suggestedComments = r_AppLogicFacade.GetSuggestedComments(m_FilteredPosts);
            PopulateListBoxOfType(suggestedComments,suggestedCommentsLst);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormGenerateComment_Load(object sender, EventArgs e)
        {

        }
    }
}
