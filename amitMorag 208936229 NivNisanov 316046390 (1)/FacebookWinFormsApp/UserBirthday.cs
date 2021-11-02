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

        public UserBirthday(User i_User, DateTime i_BirthdayDate)
        {
            m_User = i_User;
            m_BirthdayDate = i_BirthdayDate;
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
        

    }
}
