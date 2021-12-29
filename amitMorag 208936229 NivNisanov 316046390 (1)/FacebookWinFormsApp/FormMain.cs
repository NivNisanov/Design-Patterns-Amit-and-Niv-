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
using System.Threading;


namespace BasicFacebookFeatures
{
    public sealed partial class FormMain : Form
    {
        private User m_LoggedInUser;
        private readonly FacebookAppLogicFacade r_AppLogicFacade;
        private static FormMain s_Instance = null;
        private static readonly object sr_LockObject = new object();

        public static FormMain Instance
        {
            get
            {
                if(s_Instance == null)
                {
                    lock(sr_LockObject)
                    {
                        if(s_Instance == null)
                        {
                            s_Instance = new FormMain();
                        }
                    }
                }

                return s_Instance;
            }
        }

        private FormMain()
        {
            InitializeComponent();
            r_AppLogicFacade = new FacebookAppLogicFacade();
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
            hideUIAfterLogout();
        }

        private void generateCommentsButton_Click(object sender, EventArgs e)
        {
            Form formGenerateComment = FormFactory.createForm("generateComment");
            formGenerateComment.Show();
        }

        private void birthdaysWishesButton_Click(object sender, EventArgs e)
        {
            Form findAndPrepareBirthdaysForm = FormFactory.createForm("findAndPrepareBirthdayWishesToCal");
            findAndPrepareBirthdaysForm.Show();
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
            dataBindingPanel.Visible = true;
            birthdaysWishesButton.Visible = true;
            buttonLogout.Visible = true;
            friendsListBox.Visible = true;
            r_AppLogicFacade.FetchFriends(membersBindingSource);
            userPictures.Visible = true;
            showPhotos();
            userPictures.SendToBack();
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
        }

        private void hideUIAfterLogout() 
        {
            profilePic.Visible = false;
            pictureBox1.Visible = false;
            generateCommentsButton.Visible = false;
            birthdaysWishesButton.Visible = false;
            buttonLogout.Visible = false;
            dataBindingPanel.Visible = false;
            buttonLogin.Visible = true;
        }

        private void fetchPhotos(PictureBox[] i_PhotosArray)
        {
            r_AppLogicFacade.FetchPhotos(i_PhotosArray, userPictures.Location);

            foreach(PictureBox picture in i_PhotosArray)
            {
                Controls.Add(picture);
            }
        }

        private void showPhotos()
        {
            PictureBox[] photosArray = new PictureBox[6];
            fetchPhotos(photosArray);
            r_AppLogicFacade.StopWhenMouseOverPictures(userPictures);
            r_AppLogicFacade.MovePhotos(this.Size.Width);
        }
    }
}
