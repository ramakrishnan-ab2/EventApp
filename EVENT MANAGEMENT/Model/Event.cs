using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVENT_MANAGEMENT.Model
{
   public class Event
    {
        [Key]
        public int Id { get; set; }
        public string EventName { get; set; }
        public override string ToString()
        {
            return EventName;
        }
    }
}
