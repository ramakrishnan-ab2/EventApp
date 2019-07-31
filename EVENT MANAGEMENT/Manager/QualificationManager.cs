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
        public int?[] QualificationIds { get; set; }

        public IList<Qualification> ListQualification(int CategoryId)
        {
            IList<Qualification> Qualification = null;
            using (AccountContext Context = new AccountContext())
            {
                 QualificationIds = Context.QualificationCategorys.Where(x => x.CategoryId == CategoryId).Select(y => y.QualificationId).ToArray();
                if (QualificationIds.Length >0)
                {
                    Qualification = (from Qualifications in Context.Qualifications where QualificationIds.Contains(Qualifications.Id) select Qualifications).ToList();
                }
                else
                {
                    Qualification = (from Qualifications in Context.Qualifications select Qualifications).ToList();
                }
            }
            return Qualification;
        }
        //public IList<Qualification> ListQualification()
        //{
        //    IList<Qualification> Qualification = null;
        //    using (AccountContext Context = new AccountContext())
        //    {
        //        Qualification = Context.Qualifications.Distinct().ToList();
        //    }
        //    return Qualification;
        //}
    }
}
