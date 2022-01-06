using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    class FindAndPrepareBirthdaysFeature: FeatureWithTextGenerator
    {
        private readonly FacebookObjectCollection<User> r_FriendsList;
        private readonly User r_UserLoggedIn;
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        private readonly List<UserBirthday> r_FriendsBirthdays;
        private CalendarCreator m_Calendar;
        public FindAndPrepareBirthdaysFeature():base("birthdayWishesToCal")
        {
            r_UserLoggedIn = FormMain.Instance.LoggedInUser;
            r_FriendsList = r_UserLoggedIn.Friends;
            r_FriendsBirthdays = new List<UserBirthday>();
            m_Calendar = new CalendarCreator();
        }

        public void FetchFriendsBirthdaysAtTime()
        {
            r_FriendsBirthdays.Clear();
            m_Calendar.Clear();
            //List<string> friendsBirthdaysList = new List<string>();

            foreach (User friend in r_FriendsList)
            {
                DateTime friendBirthday = DateTime.Parse(friend.Birthday, new CultureInfo("en-CA"));
                int numOfYears = EndTime.Year - StartTime.Year + 1;

                if (DateTime.Compare(StartTime, EndTime) < 0)
                {
                    for (int i = 0; i < numOfYears; i++)
                    {
                        DateTime friendBirthdayInIntervalTime = new DateTime(
                            StartTime.Year + i,
                            friendBirthday.Month,
                            friendBirthday.Day);
                        bool isBirthdayAfterStartTime = DateTime.Compare(friendBirthdayInIntervalTime, StartTime) >= 0;
                        bool isBirthdayBeforeEndTime = DateTime.Compare(friendBirthdayInIntervalTime, EndTime) <= 0;

                        if (isBirthdayAfterStartTime && isBirthdayBeforeEndTime)
                        {
                            //friendsBirthdaysList.Add($"{friend.Name} at {friendBirthdayInIntervalTime.ToShortDateString()}");
                            //UserBirthday userToAdd = new UserBirthday(friend, friendBirthdayInIntervalTime);
                           // userToAdd.BirthdayWish = this.m_textGenerator.GenerateText(friend, friendBirthdayInIntervalTime.ToString("MM/dd/yyyy"));
                            string birthdayWish = this.m_textGenerator.GenerateText(friend, friendBirthdayInIntervalTime.ToString("MM/dd/yyyy"));
                            m_Calendar.AddEvent(friendBirthdayInIntervalTime,friend, birthdayWish);
                            
                           // r_FriendsBirthdays.Add(userToAdd);
                        }
                    }
                }
                else
                {
                    throw new Exception($"Start date ({StartTime}) is after the end date ({EndTime}).");
                }
            }

            //TODO: sort before return with strategy!

            //return friendsBirthdaysList;
        }

        public List<string> GetSortedBirthdayEvents()
        {
            CalendarEventSorter sorter =
                new CalendarEventSorter((event1, event2) => event1.DateOfEvent.Date > event2.DateOfEvent.Date);
            List<CalendarEvent> sortedEvents = sorter.Sort(m_Calendar);
            List<string> sortedBirthdays = new List<string>();

            foreach(CalendarEvent calEvent in sortedEvents)
            {
                sortedBirthdays.Add($"{calEvent.NameOfEvent} at {calEvent.DateOfEvent.ToShortDateString()}");
            }

            return sortedBirthdays;
        }

        public void ExportAndOpenCalendar()
        {
            //CalendarCreator calendar = new CalendarCreator();
            //foreach (UserBirthday birthday in r_FriendsBirthdays)
            //{
            //    calendar.AddEvent(birthday.BirthdayDate, birthday.User, birthday.BirthdayWish);
            //}
            //calendar.ExportCalendar("BirthdayHelper");
            //calendar.OpenCalendar();

            m_Calendar.ExportCalendar("BirthdayHelper");
            m_Calendar.OpenCalendar();
        }
    }
}
