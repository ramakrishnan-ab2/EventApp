using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVENT_MANAGEMENT.Model
{
    public class Register
    {
        [Key]
        public int Id { get; set; }
        public string StudentName { get; set; }
        public int? QualificationId { get; set; }
        public virtual Qualification Qualification { get; set; }
        public int? CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public int? EventId { get; set; }
        public virtual Event Event { get; set; }
        public int EventRollNo { get; set;  }
        public int? SchoolId{ get; set; }
        public virtual School School { get; set; }
        public string PhoneNo { get; set; }
        public string FathersName { get; set; }
        public DateTime Date { get; set; }
        public double Fee { get; set; }
        public override string ToString()
        {
            return StudentName;
        }
    }
}
