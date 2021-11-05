
    using System;
    using BasicFacebookFeatures;
    using FacebookWrapper.ObjectModel;

    public class CommentGenerator : TextGenerator
    {
        private const int k_PoliteAge = 50;
        private string[] m_RegularFemaleEnding = { ":)", "sweetheart!", "dear", "sis" };
        private string[] m_PoliteOpeningWords = { "Good", "A pleasant" };
        private string[] m_PoliteThanksWords = { "Thanks", "Thank you very much" };
        private string[] m_PoliteEndingWords = { "I hope to see you soon!", "Hope we meet in the near future.", "It was nice hearing from you." };
        private string[] m_RegularOpeningWords = { "Thanks", "ty, cu soon", "Appreciate it", "haha ty" };
        private string[] m_RegularMaleEnding = { "bro", "man", "dude" };
        //private Post m_FriendPost;
        private bool m_IsPolite;
        private bool m_IsUserMale = true;
        //private User m_PostAuthor;
        private readonly Random r_Randomizer = new Random();

        public override string GenerateText(User i_PostAuthor)
        {
            m_User = i_PostAuthor;
            //m_FriendPost = i_PostAuthor; ---remove
            generateFriendInfo();
            string comment = generateCommentBasedOnInfo();
            return comment;
        }

        private string generateCommentBasedOnInfo()
        {
            // comment of the form "Good <time_of_day>, <name>. Thanks for the kind words! Hope to see you soon.
            const string k_GeneralPoliteThankYouComment = "{0} {1}, {2}. {3}. {4}";
            const string k_GeneralRegularThankYouComment = "{0} {1}";
            string generatedComment = String.Empty;

            if (m_IsPolite)
            {
                string timeOfDayGreeting = TimeOfDay.GetGreetingByTimeOfDay();
                string politeOpening = m_PoliteOpeningWords[r_Randomizer.Next(m_PoliteOpeningWords.Length)];
                string politeThanks = m_PoliteThanksWords[r_Randomizer.Next(m_PoliteThanksWords.Length)];
                string politeEnding = m_PoliteEndingWords[r_Randomizer.Next(m_PoliteEndingWords.Length)];

                generatedComment = string.Format(k_GeneralPoliteThankYouComment,
                    politeOpening, timeOfDayGreeting, m_User.Name, politeThanks, politeEnding);
            }
            else
            {
                string regularOpening = m_RegularOpeningWords[r_Randomizer.Next(m_RegularOpeningWords.Length)];
                string regularEnding = (m_IsUserMale) ?
                    m_RegularMaleEnding[r_Randomizer.Next(m_RegularMaleEnding.Length)] : m_RegularFemaleEnding[r_Randomizer.Next(m_RegularFemaleEnding.Length)];

                generatedComment = string.Format(k_GeneralRegularThankYouComment,
                    regularOpening, regularEnding);
            }

            return generatedComment;
        }

        private void generateFriendInfo()
        {
            // Get user of the post and determine gender.
            
            //m_PostAuthor = m_FriendPost.From; --remove

            if (m_User != null)
            {
                m_IsUserMale = (m_User.Gender == User.eGender.male);
            }

            // Get user age and determine if the comment should be Polite\Regular\Childish
            int userAge = getUserAge();
            m_IsPolite = (userAge >= k_PoliteAge);
        }

        /*
        private int getUserAge()
        {
            DateTime userAge = translateUserAgeStringToDateTime();
            int userAgeInDays = (int)(DateTime.Now - userAge).TotalDays;

            return userAgeInDays / 365;
        }

        private DateTime translateUserAgeStringToDateTime()
        {
            //                            [0] [1] [2]
            // Birthday is in this format "MM/DD/YYYY"
            DateTime userBirthdayDateTime = DateTime.Today;

            if (m_PostAuthor?.Birthday != null)
            {
                string userBirthdayString = m_PostAuthor.Birthday;
                string[] birthdayStringSplit = userBirthdayString.Split('/');
                int[] birthdayIntSplit = Array.ConvertAll(birthdayStringSplit, int.Parse);
                userBirthdayDateTime = new DateTime(birthdayIntSplit[2], birthdayIntSplit[0], birthdayIntSplit[1]);
            }

            return userBirthdayDateTime;
        }
        */
    }

