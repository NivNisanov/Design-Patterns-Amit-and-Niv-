using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Drawing;
using System.Threading;
using Timer = System.Windows.Forms.Timer;

namespace BasicFacebookFeatures
{
    class FacebookAppLogicFacade
    {
        private const int k_NumberOfPhotos = 6;
        private const int k_TimeInterval = 30;
        private const int k_SpacesBetweenPhotos = 23;
        private const int k_PhotosSquareSize = 100;
        private const int k_SlidePhotosYOffset = 5;
        private const int k_SlidePhotosMaxSpeed = 1;
        private PictureBox[] m_PhotosArray = new PictureBox[k_NumberOfPhotos];
        private int m_PicturesSpeed = 1;
        private int m_FormWidth;

        public FacebookAppLogicFacade()
        {

        }

        public void FetchFriends(BindingSource i_BindingSource)
        {
            i_BindingSource.DataSource = MainFormSingleton.Instance.LoggedInUser.Friends;
        }

        public void StopWhenMouseOverPictures(PictureBox i_PhotosPanel)
        {
            i_PhotosPanel.MouseEnter += hoverPictures_MouseEnter;
            i_PhotosPanel.MouseLeave += hoverPictures_MouseLeave;

            foreach(PictureBox picture in m_PhotosArray)
            {
                picture.MouseEnter += hoverPictures_MouseEnter;
                picture.MouseLeave += hoverPictures_MouseLeave;
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

        public void FetchPhotos(PictureBox[] i_PhotosArray, Point i_PanelPosition) 
        {
            m_PhotosArray = i_PhotosArray;
            for (int i = 0; i < m_PhotosArray.Length; i++)
            {
                int pictureIndex;
                m_PhotosArray[i] = new PictureBox();
                if (MainFormSingleton.Instance.LoggedInUser.PhotosTaggedIn.Count != 0)
                {
                    m_PhotosArray[i].LoadAsync(getRandomUserPhoto(out pictureIndex, m_PhotosArray));
                    m_PhotosArray[i].Name = pictureIndex.ToString();
                }
                else
                {
                    m_PhotosArray[i].Image = null;
                }

                m_PhotosArray[i].SizeMode = PictureBoxSizeMode.StretchImage;
                m_PhotosArray[i].Size = new Size(k_PhotosSquareSize, k_PhotosSquareSize);
                m_PhotosArray[i].Location = new Point((i * k_PhotosSquareSize) + (k_SpacesBetweenPhotos * (i + 1)), i_PanelPosition.Y + k_SlidePhotosYOffset);
            }
        }

        private string getRandomUserPhoto(out int o_PictureIndex, PictureBox[] i_PhotosArray)
        {
            Random random = new Random();
            int countOfPhotosTaggedIn = MainFormSingleton.Instance.LoggedInUser.PhotosTaggedIn.Count;
            int randomNumber = random.Next(0, countOfPhotosTaggedIn);

            while (countOfPhotosTaggedIn > k_NumberOfPhotos && photoAlreadyShown(randomNumber, i_PhotosArray))
            {
                randomNumber = random.Next(0, countOfPhotosTaggedIn);
            }

            o_PictureIndex = randomNumber;
            string url = MainFormSingleton.Instance.LoggedInUser.PhotosTaggedIn[randomNumber].PictureNormalURL;

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

        public void MovePhotos(int i_FormWidth)
        {
            m_FormWidth = i_FormWidth;
            Timer timer = new Timer();
            timer.Interval = k_TimeInterval;
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < m_PhotosArray.Length; i++)
            {
                m_PhotosArray[i].Left += m_PicturesSpeed;
                if (m_PhotosArray[i].Location.X > m_FormWidth)
                {
                    int pictureIndex;
                    if (MainFormSingleton.Instance.LoggedInUser.PhotosTaggedIn.Count != 0)
                    {
                        m_PhotosArray[i].LoadAsync(getRandomUserPhoto(out pictureIndex, m_PhotosArray)); 
                        m_PhotosArray[i].Name = pictureIndex.ToString();
                    }
                    else
                    { 
                        m_PhotosArray[i].Image = null;
                    }

                    m_PhotosArray[i].Location = new Point(-1 * m_PhotosArray[i].Size.Width, m_PhotosArray[i].Location.Y);
                }
            }
        }
    }
}
