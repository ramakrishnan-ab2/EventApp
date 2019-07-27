using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVENT_MANAGEMENT.Model
{
    public class Registration
    {
        public int Id
        {
            get; set;
        }
        public string Name
        {
            get; set;
        }
        public int QualificationId
        {
            get; set;
        }
        public int EventId
        {
            get; set;
        }
        public int EventRollNo
        {
            get; set;
        }
        public int SchoolId
        {
            get; set;
        }
        public string PhoneNo
        {
            get; set;
        }
        public string FathersName
        {
            get; set;
        }
        public DateTime Date
        {
            get; set;
        }

    }
}
