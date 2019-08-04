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
        public int?[] CategoryI { get; set; }
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
        public IList<Category> ListCategoryl(int eId)
        {
            IList<Category> Categor = null;
            using (AccountContext Context = new AccountContext())
            {
                CategoryI = Context.EventCategories.Where(x => x.EventId== eId).Select(y => y.CategoryId).ToArray();
                if (CategoryI.Length > 0)
                {
                    Categor = (from Categorys in Context.Categorys  where CategoryI.Contains(Categorys.Id) select Categorys).ToList<Category>();
                }
                //else
                //{
                //    Category = (from Categorys in Context.Categorys select Categorys).ToList();
                //}
            }
            return Categor;
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
