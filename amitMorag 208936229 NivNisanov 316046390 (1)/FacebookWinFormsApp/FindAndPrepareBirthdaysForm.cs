using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FindAndPrepareBirthdaysForm : Form
    {
        private FacebookObjectCollection<Page> m_MusicArtists;
        private FacebookObjectCollection<User> m_FriendsList;
        private List<Event> m_Events;
        private DateTime m_StartTime;
        private DateTime m_EndTime;
        private User m_UserLoggedIn;
        private List<UserBirthday> m_FriendsBirthdays;

        public FindAndPrepareBirthdaysForm(User i_UserLoggedIn)
        {
            InitializeComponent();
            m_UserLoggedIn = i_UserLoggedIn;
            m_FriendsList = m_UserLoggedIn.Friends;
            m_FriendsBirthdays = new List<UserBirthday>();
            profilePic.Image = m_UserLoggedIn.ImageNormal;
            coverPic.Image = m_UserLoggedIn.Albums[1].Photos[0].ImageNormal;
            //FetchFriendsBirthdaysAtTime();
            //GetEvents();
        }

        public List<Event> GetEvents()
        {
            //to remove
            m_MusicArtists = FacebookService.GetCollection<Page>("music");
            FetchMusicEvents();

            return m_Events;
        }

        public void FetchFriendsBirthdaysAtTime()
        {
            m_FriendsBirthdays.Clear();

            foreach (User friend in m_FriendsList)
            {
                DateTime friendBirthday = DateTime.Parse(friend.Birthday,new CultureInfo("en-CA"));
                int numOfYears = m_EndTime.Year - m_StartTime.Year;
                if(DateTime.Compare(m_StartTime, m_EndTime) < 0)
                {
                    for(int i = 0; i < numOfYears; i++)
                    {
                        DateTime friendBirthdayInIntervalTime = new DateTime(
                            m_StartTime.Year + i,
                            friendBirthday.Month,
                            friendBirthday.Day);
                        int start = DateTime.Compare(friendBirthdayInIntervalTime, m_StartTime);
                        int end = DateTime.Compare(friendBirthdayInIntervalTime, m_EndTime);
                        if (DateTime.Compare(friendBirthdayInIntervalTime, m_StartTime) >= 0
                           && DateTime.Compare(friendBirthdayInIntervalTime, m_EndTime) <= 0)
                        {
                            listOfEvents.Items.Add($"{friend.Name} at {friendBirthdayInIntervalTime.ToShortDateString()}");
                            m_FriendsBirthdays.Add(new UserBirthday(friend,friendBirthdayInIntervalTime));
                            //i_Calendar.AddEvent(friendBirthdayInIntervalTime, friend);
                        }
                    }
                }
            }
        }

        private void FetchMusicEvents()
        {
            //to remove
            for (int i = 0; i < m_MusicArtists.Count; i++)
            {
                FacebookObjectCollection<Event> eventsList = m_MusicArtists[i].Events;
                for (int j = 0; j < eventsList.Count; j++)
                {
                    Event currentEvent = eventsList[j];

                    if (currentEvent.InterestedCount > 100)
                    {
                        if (DateTime.Compare(currentEvent.StartTime.Value,m_StartTime) > 0 && DateTime.Compare(currentEvent.EndTime.Value, m_EndTime) < 0)
                        {
                            m_Events.Add(currentEvent);
                        }
                    }
                }
            }
        }

        private void searchEventsButton_Click(object sender, EventArgs e)
        {
            m_StartTime = startDateTimePicker.Value;
            m_EndTime = endDateTimePicker.Value;
            FetchFriendsBirthdaysAtTime();
            //calendar.ExportCalendar();
            generateCalendarButton.Enabled = true;
            generateCalendarButton.Visible = true;
            //calendar.OpenCalendar();
            //m_Events = GetEvents();
            //foreach(Event eventToAdd in m_Events)
            //{
            //   listOfEvents.Items.Add(eventToAdd.Name);
            //}

        }

        private void GenerateCalendarButton_Click(object sender, EventArgs e)
        {
            CalendarCreator calendar = new CalendarCreator();
            foreach(UserBirthday birthday in m_FriendsBirthdays)
            {
                calendar.AddEvent(birthday.BirthdayDate, birthday.User);
            }
            calendar.ExportCalendar();
            calendar.OpenCalendar();
            
        }
    }
}
