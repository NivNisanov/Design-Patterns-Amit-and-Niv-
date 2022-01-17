using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class CalendarEventSorter
    {
        public Func<CalendarEvent, CalendarEvent,bool> CompareMethod { get; set; }

        public CalendarEventSorter(Func<CalendarEvent, CalendarEvent, bool> i_CompareMethod)
        {
            CompareMethod = i_CompareMethod;
        }

        public List<CalendarEvent> Sort(CalendarCreator i_Calendar)
        {
            List<CalendarEvent> events = new List<CalendarEvent>();
            foreach (CalendarEvent CalEvent in i_Calendar)
            {
                events.Add(CalEvent);
            }

            for (int i = events.Count / 2; i > 0; i /= 2)
            {
                for(int j = i; j < events.Count; j++)
                {
                    for(int k = j-i; k >= 0; k -= i)
                    {
                        if(CompareMethod.Invoke(events[k], events[k + i]))
                        {
                            CalendarEvent temp = events[k];
                            events[k] = events[k + i];
                            events[k + i] = temp;
                        }
                    }
                }
            }

            return events;
        }
    }
}
