using EVENT_MANAGEMENT.Context;
using EVENT_MANAGEMENT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVENT_MANAGEMENT.Manager
{
    public class MarkEntryManager
    {
        private static volatile MarkEntryManager instance;
        private static object syncRoot = new Object();
        public static MarkEntryManager Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new MarkEntryManager();
                    }
                }

                return instance;
            }
        }
       
        public IList<Event> ListEvent()
        {
           
            using (AccountContext Context = new AccountContext())
            {
                IList<Event> EventInfo = Context.Events.ToList<Event>();
                return EventInfo;
            }
           
        }
       
        public Event GetEventById(long EventId)
        {
            Event EventInfo = null;
            using (AccountContext Context = new AccountContext())
            {
                EventInfo = Context.Events.Find(EventId);
                return EventInfo;
            }
        }
        public static void InitializeReferedCombo(ToolStripComboBox SelectBox)
        {
            MarkEntryManager ReferedManager = MarkEntryManager.Instance;
            SelectBox.Items.Clear();
            SelectBox.Items.AddRange(ReferedManager.ListEvent().ToArray<Event>());
            SelectBox.SelectedIndex = -1;
        }
        public IList<Event> ListEventRollNo(long EventId)
        {
            using (AccountContext Context = new AccountContext())
            {
                IList<Event> EventInfo = Context.Events.Where(x => x.Id == EventId).ToList<Event>();
                return EventInfo;
            }
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
        public Event AddEvent(Event Eventinfo)
        {
            Event EventInfo = null;
            if (Eventinfo != null)
            {
                using (AccountContext AccountContext = new AccountContext())
                {
                   EventInfo= AccountContext.Events.Add(Eventinfo);
                }
            }
            return EventInfo;

        }
    }
}
