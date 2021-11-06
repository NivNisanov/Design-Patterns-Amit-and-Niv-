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
        private readonly FacebookObjectCollection<User> r_FriendsList;
        private DateTime m_StartTime;
        private DateTime m_EndTime;
        private User m_UserLoggedIn;
        private readonly List<UserBirthday> r_FriendsBirthdays;

        public FindAndPrepareBirthdaysForm(User i_UserLoggedIn)
        {
            InitializeComponent();
            m_UserLoggedIn = i_UserLoggedIn;
            r_FriendsList = m_UserLoggedIn.Friends;
            r_FriendsBirthdays = new List<UserBirthday>();
            profilePic.Image = m_UserLoggedIn.ImageNormal;
            coverPic.Image = m_UserLoggedIn.Albums[1].Photos[0].ImageNormal;
        }

        public void FetchFriendsBirthdaysAtTime()
        {
            r_FriendsBirthdays.Clear();
            listOfEvents.Items.Clear();

            foreach (User friend in r_FriendsList)
            {
                
                DateTime friendBirthday = DateTime.Parse(friend.Birthday,new CultureInfo("en-CA"));
                int numOfYears = m_EndTime.Year - m_StartTime.Year;
                if(DateTime.Compare(m_StartTime, m_EndTime) < 0)
                {
                    for (int i = 0; i < numOfYears; i++)
                    {
                        DateTime friendBirthdayInIntervalTime = new DateTime(
                            m_StartTime.Year + i,
                            friendBirthday.Month,
                            friendBirthday.Day);
                        bool isBirthdayAfterStartTime = DateTime.Compare(friendBirthdayInIntervalTime, m_StartTime) >= 0;
                        bool isBirthdayBeforeEndTime = DateTime.Compare(friendBirthdayInIntervalTime, m_EndTime) <= 0;
                        
                        if (isBirthdayAfterStartTime && isBirthdayBeforeEndTime)
                        {
                            listOfEvents.Items.Add($"{friend.Name} at {friendBirthdayInIntervalTime.ToShortDateString()}");
                            r_FriendsBirthdays.Add(new UserBirthday(friend,friendBirthdayInIntervalTime));
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
            generateCalendarButton.Enabled = true;
            generateCalendarButton.Visible = true;
        }

        private void GenerateCalendarButton_Click(object sender, EventArgs e)
        {
            CalendarCreator calendar = new CalendarCreator();
            foreach(UserBirthday birthday in r_FriendsBirthdays)
            {
                calendar.AddEvent(birthday.BirthdayDate, birthday.User, birthday.BirthdayWish);
            }
            calendar.ExportCalendar("BirthdayHelper");
            calendar.OpenCalendar();
            
        }
    }
}
