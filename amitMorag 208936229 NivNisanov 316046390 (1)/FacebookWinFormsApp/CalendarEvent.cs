using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class CalendarEvent
    {
        public DateTime DateOfEvent { get; }
        public string NameOfEvent { get; }
        public string EventDescription { get; }

        public CalendarEvent(DateTime i_DateOfEvent, string i_NameOfEvent, string i_EventDescription)
        {
            DateOfEvent = i_DateOfEvent;
            NameOfEvent = i_NameOfEvent;
            EventDescription = i_EventDescription;
        }
    }
}
