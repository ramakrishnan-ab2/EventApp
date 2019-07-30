using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVENT_MANAGEMENT.Model
{
    public class QualificationCategory
    {
        [Key]
        public int Id { get; set; }
        public int? QualificationId { get; set; }
        public virtual Qualification Qualification { get; set; }
        public int? CategoryId { get; set; }
        public virtual Category Category { get; set; }
        
    }
}
