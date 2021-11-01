
    using System;

    // This class is used for many purposes regarding handling the current time of day.
    public static class TimeOfDay
    {
        public static string GetGreetingByTimeOfDay()
        {
            TimeSpan morningStart = new TimeSpan(5, 0, 0);
            TimeSpan noonStart = new TimeSpan(12, 0, 0);
            TimeSpan eveningStart = new TimeSpan(18, 0, 0);
            TimeSpan nightStart = new TimeSpan(22, 0, 0);
            TimeSpan currentTime = DateTime.Now.TimeOfDay;
            string greetingText = "";

            if (currentTime >= nightStart && currentTime < morningStart)
            {
                greetingText = "night";
            }
            else if (currentTime >= morningStart && currentTime < noonStart)
            {
                greetingText = "morning";
            }
            else if (currentTime >= noonStart && currentTime < eveningStart)
            {
                greetingText = "afternoon";
            }
            else if (currentTime >= eveningStart && currentTime < nightStart)
            {
                greetingText = "evening";
            }

            return greetingText;
        }
    }
