using EVENT_MANAGEMENT.Context;
using EVENT_MANAGEMENT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVENT_MANAGEMENT.Manager
{
  public  class ResultManager
    {
     
        public IList<Result> ListEvent()
        {

            using (AccountContext Context = new AccountContext())
            {
                IList<Result> ResultInfo = Context.Results.ToList<Result>();
                return ResultInfo;
            }

        }
    }
}
