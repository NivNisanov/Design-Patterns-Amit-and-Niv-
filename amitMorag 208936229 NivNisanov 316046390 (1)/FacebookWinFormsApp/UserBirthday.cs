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
        public string BirthdayWish { get; }
        private readonly BirthdayWishGenerator r_BirthdayWishGenerator = new BirthdayWishGenerator();

        public UserBirthday(User i_User, DateTime i_BirthdayDate)
        {
            User = i_User;
            BirthdayDate = i_BirthdayDate;
            BirthdayWish = r_BirthdayWishGenerator.GenerateText(i_User, BirthdayDate.ToString("MM/dd/yyyy"));
        }
    }
}
