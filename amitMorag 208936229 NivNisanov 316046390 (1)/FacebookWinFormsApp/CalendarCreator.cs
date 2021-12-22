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
        private StringBuilder CalendarFormat { get;}
        //private StringBuilder calendarFormat = new StringBuilder();
        private string DateFormat {get;}
        //string m_DateFormat = "yyyyMMdd";
        private string CurrentTime {get;}
        //readonly string r_CurrentTime;
        private int NumberOfEvents { get; set;}
        //private int m_NumberOfEvents;
        private string NameOfFile { get; set; }
        //private string m_NameOfFile;

        public CalendarCreator()
        {
            CalendarFormat = new StringBuilder();
            DateFormat = "yyyyMMdd";
            NumberOfEvents = 0;
            CurrentTime = DateTime.Now.ToUniversalTime().ToString(DateFormat);
            CalendarFormat.AppendLine("BEGIN:VCALENDAR");
            CalendarFormat.AppendLine("PRODID:Birthdays Helper");
            CalendarFormat.AppendLine("VERSION:2.0");
            CalendarFormat.AppendLine("METHOD:PUBLISH");
            
        }

        public void AddEvent(DateTime i_Date, User i_Friend, string i_Description)
        {
            CalendarFormat.AppendLine("BEGIN:VEVENT");
            CalendarFormat.AppendLine("DTSTART;VALUE=DATE:" + i_Date.ToString(DateFormat));
            CalendarFormat.AppendLine("DTSTAMP:" + CurrentTime);
            CalendarFormat.AppendLine("UID:" + Guid.NewGuid());
            CalendarFormat.AppendLine("CREATED:" + CurrentTime);
            //calendarFormat.AppendLine("X-ALT-DESC;FMTTYPE=text/html:" + res.DetailsHTML);
            CalendarFormat.AppendLine($"DESCRIPTION:{i_Description}");
            CalendarFormat.AppendLine($"LAST-MODIFIED:{CurrentTime}");
            CalendarFormat.AppendLine($"SUMMARY:{i_Friend.Name} Birthday");
            CalendarFormat.AppendLine("END:VEVENT");
            NumberOfEvents++;
        }

        public void ExportCalendar(string i_NameofFile)
        {
            NameOfFile = i_NameofFile;
            StringBuilder calendarForExport = CalendarFormat;
            calendarForExport.AppendLine("END:VCALENDAR");

            string dirParameter = AppDomain.CurrentDomain.BaseDirectory + $@"\{NameOfFile}.ics";
            string Msg = CalendarFormat.ToString();

            FileStream fParameter = new FileStream(dirParameter, FileMode.Create, FileAccess.Write);
            StreamWriter m_WriterParameter = new StreamWriter(fParameter);
            m_WriterParameter.BaseStream.Seek(0, SeekOrigin.End);
            m_WriterParameter.Write(Msg);
            m_WriterParameter.Flush();
            m_WriterParameter.Close();
        }

        public void OpenCalendar()
        {
            System.Diagnostics.Process.Start(AppDomain.CurrentDomain.BaseDirectory + $@"\{NameOfFile}.ics");
        }
    }
}
