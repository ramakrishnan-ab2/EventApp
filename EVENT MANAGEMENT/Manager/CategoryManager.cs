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
        public int?[] CategoryIds { get; set; }

        public IList<Category> ListCategory(int QualificationId)
        {           
            IList<Category> Category = null;
            using (AccountContext Context = new AccountContext())
            {
                CategoryIds = Context.QualificationCategorys.Where(x => x.QualificationId == QualificationId).Select(y => y.CategoryId).ToArray();
                if(CategoryIds.Length>0)
                {
                    Category = (from Categorys in Context.Categorys where CategoryIds.Contains(Categorys.Id) select Categorys).ToList<Category>();
                }
                //else
                //{
                //    Category = (from Categorys in Context.Categorys select Categorys).ToList();
                //}
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
