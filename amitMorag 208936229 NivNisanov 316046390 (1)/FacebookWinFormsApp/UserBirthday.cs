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
        //private User m_User;
        public DateTime BirthdayDate { get; }
        //private DateTime m_BirthdayDate;
        public string BirthdayWish { get; }
        private string m_BirthdayWish = String.Empty;
        private BirthdayWishGenerator birthdayWishGenerator { get; }
        //private readonly BirthdayWishGenerator r_BirthdayWishGenerator;

        public UserBirthday(User i_User, DateTime i_BirthdayDate)
        {
            birthdayWishGenerator = new BirthdayWishGenerator();
            User = i_User;
            BirthdayDate = i_BirthdayDate;
            BirthdayWish = birthdayWishGenerator.GenerateText(i_User, BirthdayDate.ToString("MM/dd/yyyy"));
        }

        //public User User
        //{
        //    get
        //    {
        //        return m_User;
        //    }
        //}

        //public DateTime BirthdayDate
        //{
        //    get
        //    {
        //        return m_BirthdayDate;
        //    }
        //}

        //public string BirthdayWish
        //{
        //    get
        //    {
        //        return m_BirthdayWish;
        //    }
        //}
        

    }
}
