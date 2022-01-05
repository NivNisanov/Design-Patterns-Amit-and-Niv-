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
        public User User { get;}
        public DateTime BirthdayDate { get; }
        public string BirthdayWish { get; set; }
        

        public UserBirthday(User i_User, DateTime i_BirthdayDate)
        {
            User = i_User;
            BirthdayDate = i_BirthdayDate;
        }
    }
}
