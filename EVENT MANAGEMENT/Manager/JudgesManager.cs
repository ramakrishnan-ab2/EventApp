using EVENT_MANAGEMENT.Context;
using EVENT_MANAGEMENT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVENT_MANAGEMENT.Manager
{
    public class JudgesManager
    {
        public IList<Judges> ListJudges()
        {
            IList<Judges> Judge = null;
            using (AccountContext Context = new AccountContext())
            {
                Judge = Context.Judgeses.ToList<Judges>();
                return Judge;
            }
          
        }
    }
}
