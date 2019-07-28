using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVENT_MANAGEMENT.Model
{
    public class Result
    {
        [Key]
        public int Id { get; set; }
        public int? JudgesId { get; set; }
        public virtual Judges Judges { get; set; }
        public int? RegisterId { get; set; }
        public virtual Register Registers { get; set; }
        public double Marks { get; set; }

    }
}
