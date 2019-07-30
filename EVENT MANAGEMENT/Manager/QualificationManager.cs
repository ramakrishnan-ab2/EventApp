using EVENT_MANAGEMENT.Context;
using EVENT_MANAGEMENT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVENT_MANAGEMENT.Manager
{
   public class QualificationManager
    {
        public IList<Qualification> ListQualification()
        {
            IList<Qualification> Qualification = null;
            using (AccountContext Context = new AccountContext())
            {
                Qualification = Context.Qualifications.Distinct().ToList();
            }
            return Qualification;
        }
    }
}
