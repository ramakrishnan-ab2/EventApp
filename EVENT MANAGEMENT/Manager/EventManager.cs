using EVENT_MANAGEMENT.Context;
using EVENT_MANAGEMENT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVENT_MANAGEMENT.Manager
{
   public class EventManager
    {
      
        public Event GetEventByName(string EventName)
        {
            Event EventInfo = null;
            using (AccountContext Context = new AccountContext())
            {
                EventInfo = Context.Events.FirstOrDefault(x => x.EventName == EventName);
                return EventInfo;
            }
        }
    }
}
