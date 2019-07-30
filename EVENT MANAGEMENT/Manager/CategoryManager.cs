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
        public IList<Category> ListCategory(int QualificationId)
        {
           
            IList<Category> Category = null;
            using (AccountContext Context = new AccountContext())
            {
               // int[] CategoryIds = Context.Qualifications.Where(x=>x.)


                Category = Context.Categorys.ToList();
            }
            return Category;
        }
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
