using EVENT_MANAGEMENT.Context;
using EVENT_MANAGEMENT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVENT_MANAGEMENT.Manager
{
   public class CategoryManager
    {
        public Category AddCategory(Category CategoryFromForm)
        {
            Category Category= null;
            if (Category!= null)
            {
                using (AccountContext AccountContext = new AccountContext())
                {
                    Category = AccountContext.Categorys.Add(CategoryFromForm);
                }
            }
            return Category;

        }
    }

}
