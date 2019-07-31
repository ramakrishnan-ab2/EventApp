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
        private static volatile EventManager instance;
        private static object syncRoot = new Object();
        public static EventManager Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new EventManager();
                    }
                }

                return instance;
            }
        }
        public IList<Event> ListEvent()
            {
                IList<Event> Event = null;
                using (AccountContext Context = new AccountContext())
                {
                    Event = Context.Events.ToList();
                }
                return Event;
            }
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
