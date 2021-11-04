using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class UserBirthday
    {
        private User m_User;
        private DateTime m_BirthdayDate;
        private string m_BirthdayWish = String.Empty;

        public UserBirthday(User i_User, DateTime i_BirthdayDate)
        {
            m_User = i_User;
            m_BirthdayDate = i_BirthdayDate;
            m_BirthdayWish = "Happy Birthday!"; // TODO: change to func to get wish
        }

        public User User
        {
            get
            {
                return m_User;
            }
        }

        public DateTime BirthdayDate
        {
            get
            {
                return m_BirthdayDate;
            }
        }

        public string BirthdayWish
        {
            get
            {
                return m_BirthdayWish;
            }
        }
        

    }
}
