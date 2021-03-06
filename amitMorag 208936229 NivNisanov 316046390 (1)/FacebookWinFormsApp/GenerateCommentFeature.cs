using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    class GenerateCommentFeature: FeatureWithTextGenerator
    {

        private readonly User r_LoggedInUser;

        public GenerateCommentFeature():base("comment")
        {
            r_LoggedInUser = FormMain.Instance.LoggedInUser;
        }

        public List<Post> FilterOnlyBirthdayPosts(List<Post> i_ItemsToFilter)
        {
            List<Post> birthdayPosts = new List<Post>();
            Regex englishBirthdayMessageRegex = new Regex("[Bb][Ii][rR][tT][hH][dD][aA][yY]");
            Regex hebrewBirthdayMessageRegex = new Regex("מזל טוב");
            foreach (Post item in i_ItemsToFilter)
            {
                if (item is Post post)
                {
                    if (!string.IsNullOrEmpty(post.Message) && (hebrewBirthdayMessageRegex.IsMatch(post.Message) || englishBirthdayMessageRegex.IsMatch(post.Message)))
                    {
                        birthdayPosts.Add(post);
                    }
                }
            }

            return birthdayPosts;
        }

        public List<string> GetSuggestedComments(List<Post> i_ItemsToSuggestComment)
        {
            List<string> suggestedCommentsList = new List<string>();
            foreach (Post birthdayPost in i_ItemsToSuggestComment)
            {
                User author = birthdayPost.From;
                string birthday = null;
                if (author != null)
                {
                    birthday = author.Birthday;
                }
                string replyMessage = this.m_textGenerator.GenerateText(author, birthday);
                suggestedCommentsList.Add(replyMessage);
            }

            return suggestedCommentsList;
        }

        public List<Post> GetAllPosts()
        {
            return r_LoggedInUser.Posts.ToList();
        }
    }
}
