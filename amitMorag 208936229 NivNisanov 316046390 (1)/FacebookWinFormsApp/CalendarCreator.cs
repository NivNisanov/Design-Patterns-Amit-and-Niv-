using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class CalendarCreator : IEnumerable
    {
        private readonly StringBuilder r_CalendarFormat = new StringBuilder();
        private readonly string  r_DateFormat = "yyyyMMdd";
        private string m_CurrentTime;
        private int NumberOfEvents { get; set;}

        private readonly List<CalendarEvent> r_Events;
        private string NameOfFile { get; set; }

        public CalendarCreator()
        {
            r_Events = new List<CalendarEvent>();
            NumberOfEvents = 0;
            m_CurrentTime = DateTime.Now.ToUniversalTime().ToString(r_DateFormat);
            r_CalendarFormat.AppendLine("BEGIN:VCALENDAR");
            r_CalendarFormat.AppendLine("PRODID:Birthdays Helper");
            r_CalendarFormat.AppendLine("VERSION:2.0");
            r_CalendarFormat.AppendLine("METHOD:PUBLISH");
            
        }

        public void AddEvent(DateTime i_Date, User i_Friend, string i_Description)
        {
            r_CalendarFormat.AppendLine("BEGIN:VEVENT");
            r_CalendarFormat.AppendLine("DTSTART;VALUE=DATE:" + i_Date.ToString(r_DateFormat));
            r_CalendarFormat.AppendLine("DTSTAMP:" + m_CurrentTime);
            r_CalendarFormat.AppendLine("UID:" + Guid.NewGuid());
            r_CalendarFormat.AppendLine("CREATED:" + m_CurrentTime);
            //calendarFormat.AppendLine("X-ALT-DESC;FMTTYPE=text/html:" + res.DetailsHTML);
            r_CalendarFormat.AppendLine($"DESCRIPTION:{i_Description}");
            r_CalendarFormat.AppendLine($"LAST-MODIFIED:{m_CurrentTime}");
            r_CalendarFormat.AppendLine($"SUMMARY:{i_Friend.Name} Birthday");
            r_CalendarFormat.AppendLine("END:VEVENT");
            r_Events.Add(new CalendarEvent(i_Date, $"{i_Friend.Name} Birthday", i_Description));
            NumberOfEvents++;
        }

        public void ExportCalendar(string i_NameofFile)
        {
            NameOfFile = i_NameofFile;
            StringBuilder calendarForExport = r_CalendarFormat;
            calendarForExport.AppendLine("END:VCALENDAR");

            string dirParameter = AppDomain.CurrentDomain.BaseDirectory + $@"\{NameOfFile}.ics";
            string Msg = r_CalendarFormat.ToString();

            FileStream fParameter = new FileStream(dirParameter, FileMode.Create, FileAccess.Write);
            StreamWriter writerParameter = new StreamWriter(fParameter);
            writerParameter.BaseStream.Seek(0, SeekOrigin.End);
            writerParameter.Write(Msg);
            writerParameter.Flush();
            writerParameter.Close();
        }

        public void OpenCalendar()
        {
            System.Diagnostics.Process.Start(AppDomain.CurrentDomain.BaseDirectory + $@"\{NameOfFile}.ics");
        }

        public void Clear()
        {
            r_Events.Clear();
            NumberOfEvents = 0;
            m_CurrentTime = DateTime.Now.ToUniversalTime().ToString(r_DateFormat);
            r_CalendarFormat.Clear();
            r_CalendarFormat.AppendLine("BEGIN:VCALENDAR");
            r_CalendarFormat.AppendLine("PRODID:Birthdays Helper");
            r_CalendarFormat.AppendLine("VERSION:2.0");
            r_CalendarFormat.AppendLine("METHOD:PUBLISH");
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach(CalendarEvent calEvent in r_Events)
            {
                yield return calEvent;
            }
        }
    }
}
