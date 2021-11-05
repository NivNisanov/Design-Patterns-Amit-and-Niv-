using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class BirthdayWishGenerator : TextGenerator
    {
        private readonly string[] r_Greetings = { "Hi", "Hello", "Yo", "Hey", "Howdy", "Shalom" };
        private readonly string[] r_Wishes = { "I wish you all the best",
                                        "I wish you a lot of happiness, health and success at everything you do",
                                        "Wishing you a day filled with happiness and a year filled with joy",
                                        "To quote Shakespeare: ‘Party thine ass off!",
                                        "I hope all your birthday wishes and dreams come true",
                                        "May the joy that you have spread in the past come back to you on this day"
                                    };
        private readonly Random r_Randomizer = new Random();

        public override string GenerateText(User i_Friend)
        {
            m_User = i_Friend;
            string opening = r_Greetings[r_Randomizer.Next(r_Greetings.Length)];
            string wish = r_Wishes[r_Randomizer.Next(r_Wishes.Length)];

            return $"{opening} {m_User.FirstName}, Happy {getUserAge()} Birthday! {wish}";
        }
    }
}
