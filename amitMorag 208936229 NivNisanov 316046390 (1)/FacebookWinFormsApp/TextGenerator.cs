using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public abstract class TextGenerator
    {
        protected User User { get; set; }
        //protected User User;

        public abstract string GenerateText(User i_User, string i_BirthdayInStringy);
        
        protected int getUserAgeFromString(string i_BirthdayInString)
        {
            DateTime userUpcomingBirthday = getUserBirthdayInDateTime(i_BirthdayInString);
            DateTime userBirthday = getUserBirthdayInDateTime(User.Birthday);
            int userAgeInDays = (int)(userUpcomingBirthday - userBirthday).TotalDays;

            return userAgeInDays / 365;
        }

        private DateTime getUserBirthdayInDateTime(string i_BirthdayInString)
        {
            DateTime userBirthdayDateTime = DateTime.Today;

            if (i_BirthdayInString != null)
            {
                //string userBirthdayString = i_User.Birthday;
                string[] birthdayStringSplit = i_BirthdayInString.Split('/');
                int[] birthdayIntSplit = Array.ConvertAll(birthdayStringSplit, int.Parse);
                userBirthdayDateTime = new DateTime(birthdayIntSplit[2], birthdayIntSplit[0], birthdayIntSplit[1]);
            }

            return userBirthdayDateTime;
        }
    }
}
