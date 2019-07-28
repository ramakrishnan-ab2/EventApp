using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVENT_MANAGEMENT.Model
{
   public class EventCategory
    {
        [Key]
        public int Id { get; set;}
        public int? CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public int? EventId { get; set; }
        public virtual Event Event { get; set; }
        
    }
}
