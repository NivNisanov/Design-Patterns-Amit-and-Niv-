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

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private const int k_NumberOfPhotos = 6;
        private const int k_TimeInterval = 30;
        private const int k_SpacesBetweenPhotos = 23;
        private const int k_PhotosSquareSize = 100;
        private const int k_SlidePhotosYOffset = 5;
        private const int k_SlidePhotosMaxSpeed = 1;
        private User m_LoggedInUser;
        private readonly PictureBox[] r_PhotosArray = new PictureBox[k_NumberOfPhotos];
        private int m_PicturesSpeed = 1;

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
            hideUIAfterLogout();
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
            friendsListBox.Visible = true;
            fetchFriends();
            userPictures.Visible = true;
            showPhotos();
            label1.Visible = true;
            label2.Visible = true;
        }

        private void fetchFriends()
        {
            foreach(User friend in m_LoggedInUser.Friends)
            {
                friendsListBox.Items.Add(friend.Name);
            }
        }

        private void hideUIAfterLogout()
        {
            profilePic.Visible = false;
            pictureBox1.Visible = false;
            generateCommentsButton.Visible = false;
            birthdaysWishesButton.Visible = false;
            buttonLogout.Visible = false;
            buttonLogin.Visible = true;
        }

        private void showPhotos()
        {
            fetchPhotos();
            stopWhenMouseOverPictures();
            Timer timer = new Timer();
            timer.Interval = k_TimeInterval;
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void stopWhenMouseOverPictures()
        {
            userPictures.MouseEnter += hoverPictures_MouseEnter;
            userPictures.MouseLeave += hoverPictures_MouseLeave;
            for (int i = 0; i < r_PhotosArray.Length; i++)
            {
                r_PhotosArray[i].MouseEnter += hoverPictures_MouseEnter;
                r_PhotosArray[i].MouseLeave += hoverPictures_MouseLeave;
            }
        }

        private void hoverPictures_MouseLeave(object sender, EventArgs e)
        {
            m_PicturesSpeed = k_SlidePhotosMaxSpeed;
        }

        private void hoverPictures_MouseEnter(object sender, EventArgs e)
        {
            m_PicturesSpeed = 0;
        }

        private void fetchPhotos()
        {
            for (int i = 0; i < r_PhotosArray.Length; i++)
            {
                int pictureIndex;
                r_PhotosArray[i] = new PictureBox();
                if (m_LoggedInUser.PhotosTaggedIn.Count != 0)
                {
                    r_PhotosArray[i].LoadAsync(getRandomUserPhoto(out pictureIndex, r_PhotosArray));
                    r_PhotosArray[i].Name = pictureIndex.ToString();
                }
                else
                {
                    r_PhotosArray[i].Image = null;
                }

                r_PhotosArray[i].SizeMode = PictureBoxSizeMode.StretchImage;
                r_PhotosArray[i].Size = new Size(k_PhotosSquareSize, k_PhotosSquareSize);
                r_PhotosArray[i].Location = new Point((i * k_PhotosSquareSize) + (k_SpacesBetweenPhotos * (i + 1)), userPictures.Location.Y + k_SlidePhotosYOffset);
                Controls.Add(r_PhotosArray[i]);
            }
            userPictures.SendToBack();
        }

        private string getRandomUserPhoto(out int o_PictureIndex, PictureBox[] i_PhotosArray)
        {
            Random random = new Random();
            int countOfPhotosTaggedIn = m_LoggedInUser.PhotosTaggedIn.Count;
            int randomNumber = random.Next(0, countOfPhotosTaggedIn);

            while (countOfPhotosTaggedIn > k_NumberOfPhotos && photoAlreadyShown(randomNumber, i_PhotosArray))
            {
                randomNumber = random.Next(0, countOfPhotosTaggedIn);
            }

            o_PictureIndex = randomNumber;
            string url = m_LoggedInUser.PhotosTaggedIn[randomNumber].PictureNormalURL;

            return url;
        }

        private bool photoAlreadyShown(int i_NameOfPhoto, PictureBox[] i_PhotosArray)
        {
            int i = 0;
            bool photoExists = false;

            while (i < i_PhotosArray.Length && i_PhotosArray[i] != null)
            {
                if (i_PhotosArray[i].Name == i_NameOfPhoto.ToString())
                {
                    photoExists = true;
                    break;
                }

                i++;
            }

            return photoExists;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < r_PhotosArray.Length; i++)
            {
                r_PhotosArray[i].Left += m_PicturesSpeed;
                if (r_PhotosArray[i].Location.X > this.Size.Width)
                {
                    int pictureIndex;
                    if (m_LoggedInUser.PhotosTaggedIn.Count != 0)
                    {
                        r_PhotosArray[i].LoadAsync(getRandomUserPhoto(out pictureIndex, r_PhotosArray));
                        r_PhotosArray[i].Name = pictureIndex.ToString();
                    }
                    else
                    {
                        r_PhotosArray[i].Image = null;
                    }

                    r_PhotosArray[i].Location = new Point(-1 * r_PhotosArray[i].Size.Width, r_PhotosArray[i].Location.Y);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
