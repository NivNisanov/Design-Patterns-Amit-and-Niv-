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
    class FindAndPrepareBirthdaysFeature
    {
        private readonly FacebookObjectCollection<User> r_FriendsList;
        private readonly User r_UserLoggedIn;
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        private readonly List<UserBirthday> r_FriendsBirthdays;

        public FindAndPrepareBirthdaysFeature()
        {
            r_UserLoggedIn = FormMain.Instance.LoggedInUser;
            r_FriendsList = r_UserLoggedIn.Friends;
            r_FriendsBirthdays = new List<UserBirthday>();
        }

        public List<string> FetchFriendsBirthdaysAtTime()
        {
            r_FriendsBirthdays.Clear();
            List<string> friendsBirthdaysList = new List<string>();

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
                            friendsBirthdaysList.Add($"{friend.Name} at {friendBirthdayInIntervalTime.ToShortDateString()}");
                            //i_ListOfEvents.Items.Add($"{friend.Name} at {friendBirthdayInIntervalTime.ToShortDateString()}");
                            r_FriendsBirthdays.Add(new UserBirthday(friend, friendBirthdayInIntervalTime));
                        }
                    }
                }
                else
                {
                    throw new Exception($"Start date ({StartTime}) is after the end date ({EndTime}).");
                }
            }

            return friendsBirthdaysList;
        }

        public void ExportAndOpenCalendar()
        {
            CalendarCreator calendar = new CalendarCreator();
            foreach (UserBirthday birthday in r_FriendsBirthdays)
            {
                calendar.AddEvent(birthday.BirthdayDate, birthday.User, birthday.BirthdayWish);
            }
            calendar.ExportCalendar("BirthdayHelper");
            calendar.OpenCalendar();
        }
    }
}
