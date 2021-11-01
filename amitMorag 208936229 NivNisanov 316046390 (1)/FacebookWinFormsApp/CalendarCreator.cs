using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class CalendarCreator
    {
        private StringBuilder calendarFormat = new StringBuilder();
        string m_DateFormat = "yyyyMMdd";
        readonly string r_CurrentTime;
        private int m_NumberOfEvents;

        public CalendarCreator()
        {
            m_NumberOfEvents = 0;
            r_CurrentTime = DateTime.Now.ToUniversalTime().ToString(m_DateFormat);
            calendarFormat.AppendLine("BEGIN:VCALENDAR");
            calendarFormat.AppendLine("PRODID:Birthdays Helper");
            calendarFormat.AppendLine("VERSION:2.0");
            calendarFormat.AppendLine("METHOD:PUBLISH");
            
        }

        public void AddEvent(DateTime i_Date, User i_Friend)
        {
            string birthdayWish = "test wish"; //= BirthdayWishGenarator(i_Date, friend);
            calendarFormat.AppendLine("BEGIN:VEVENT");
            calendarFormat.AppendLine("DTSTART;VALUE=DATE:" + i_Date.ToString(m_DateFormat));
            calendarFormat.AppendLine("DTSTAMP:" + r_CurrentTime);
            calendarFormat.AppendLine("UID:" + Guid.NewGuid());
            calendarFormat.AppendLine("CREATED:" + r_CurrentTime);
            //calendarFormat.AppendLine("X-ALT-DESC;FMTTYPE=text/html:" + res.DetailsHTML);
            calendarFormat.AppendLine($"DESCRIPTION:{birthdayWish}");
            calendarFormat.AppendLine($"LAST-MODIFIED:{r_CurrentTime}");
            calendarFormat.AppendLine($"SUMMARY:{i_Friend.Name} Birthday");
            calendarFormat.AppendLine("END:VEVENT");
            m_NumberOfEvents++;
        }

        public void ExportCalendar()
        {
            StringBuilder calendarForExport = calendarFormat;
            calendarForExport.AppendLine("END:VCALENDAR");

            string dirParameter = AppDomain.CurrentDomain.BaseDirectory + @"\BirthdayHelper.ics";
            string Msg = calendarFormat.ToString();

            FileStream fParameter = new FileStream(dirParameter, FileMode.Create, FileAccess.Write);
            StreamWriter m_WriterParameter = new StreamWriter(fParameter);
            m_WriterParameter.BaseStream.Seek(0, SeekOrigin.End);
            m_WriterParameter.Write(Msg);
            m_WriterParameter.Flush();
            m_WriterParameter.Close();
        }

        public void OpenCalendar()
        {
            System.Diagnostics.Process.Start(AppDomain.CurrentDomain.BaseDirectory + @"\BirthdayHelper.ics");
        }
    }
}
