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
        public int?[] EventIds { get; set; }
        public IList<Event> ListEvent(int CategoryId)
        {
            IList<Event> Event = null;
            using (AccountContext Context = new AccountContext())
            {
                EventIds = Context.EventCategories.Where(x => x.CategoryId == CategoryId).Select(y => y.EventId).ToArray();
                if (EventIds.Length>0)
                {
                    Event = (from Events in Context.Events where EventIds.Contains(Events.Id) select Events).ToList();
                }
                else
                {
                    Event = (from Events in Context.Events select Events).ToList();
                }
            }
            return Event;
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
