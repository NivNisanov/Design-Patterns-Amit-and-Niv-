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
        protected User m_User;

        public abstract string GenerateText(User i_User);
        
        protected int getUserAge()
        {
            DateTime userAge = getUserBirthdayInDateTime(m_User);
            int userAgeInDays = (int)(DateTime.Now - userAge).TotalDays;

            return userAgeInDays / 365;
        }

        private DateTime getUserBirthdayInDateTime(User i_User)
        {
            return DateTime.Parse(i_User.Birthday, new CultureInfo("en-CA"));
        }
    }
}
