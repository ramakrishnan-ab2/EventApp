using EVENT_MANAGEMENT.Context;
using EVENT_MANAGEMENT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVENT_MANAGEMENT.Manager
{
    public class SchoolManager
    {
        public School AddSchoolInfo(School SchoolForm)
        {
            School Schooldetail = null;
            if (SchoolForm != null)
            {
                using (AccountContext Context = new AccountContext())
                {
                    Schooldetail = Context.Schools.Add(SchoolForm);
                }
            }
            return Schooldetail;

        }

    }
}
