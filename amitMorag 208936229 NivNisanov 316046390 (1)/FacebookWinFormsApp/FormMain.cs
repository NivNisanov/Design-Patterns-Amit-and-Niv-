﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private User m_LoggedInUser;

        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
        }

        public User LoggedInUser
        {
            get { return m_LoggedInUser; }
            set { m_LoggedInUser = value; }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //Clipboard.SetText("design.patterns20cc"); /// the current password for Desig Patter
            FacebookWrapper.LoginResult loginResult = FacebookService.Login(
                    "1208085729677514",
                    "email",
                    "public_profile",
                    "user_posts",
                    "user_photos",
                    "user_gender",
                    "user_videos",
                    "user_friends",
                    "user_events",
                    "user_likes",
                    "pages_manage_engagement",
                    "pages_read_user_content",
                    "user_birthday",
                    "user_age_range",
                    "user_gender",
                    "user_link",
                    "user_videos",
                    "user_friends",
                    "user_events",
                    "user_likes",
                    "user_photos",
                    "user_posts"
                    );
            m_LoggedInUser = loginResult.LoggedInUser;
            if(loginResult.FacebookOAuthResult != null)
            {
                buttonLogin.Visible = false;
                showUIAfterLogin();
            }
            else
            {
                MessageBox.Show("Log in Failed","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
			FacebookService.LogoutWithUI();
            HideUIAfterLogout();
        }

        private void generateCommentsButton_Click(object sender, EventArgs e)
        {
            FormGenerateComment formGenerateComment = new FormGenerateComment(m_LoggedInUser);
            formGenerateComment.Show();
        }

        private void musicalEventsFinderButton_Click(object sender, EventArgs e)
        {
            FindAndPrepareBirthdaysForm musicalForm = new FindAndPrepareBirthdaysForm(m_LoggedInUser);
            musicalForm.Show();
        }

        private void showUIAfterLogin()
        {
            profilePic.Visible = true;
            profilePic.Image = m_LoggedInUser.ImageNormal;
            pictureBox1.Visible = true;
            if(m_LoggedInUser.Albums[1].Photos[0] != null)
            {
                pictureBox1.Image = m_LoggedInUser.Albums[1].Photos[0].ImageNormal;
            }
            else
            {
                pictureBox1.ForeColor = Color.DodgerBlue;
            }

            generateCommentsButton.Visible = true;
            birthdaysWishesButton.Visible = true;
            buttonLogout.Visible = true;
        }

        private void HideUIAfterLogout()
        {
            profilePic.Visible = false;
            pictureBox1.Visible = false;
            generateCommentsButton.Visible = false;
            birthdaysWishesButton.Visible = false;
            buttonLogout.Visible = false;
            buttonLogin.Visible = true;
        }
    }
}
