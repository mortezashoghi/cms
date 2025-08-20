using cms.core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cms.core.Interface.Repository
{
    public interface IcategoryRepository
    {
        Category GetCategory(int id);
        Category GetCategory(string categoryName);
        List<Category> GetAllCategories();
        int add(Category category);
        Category edit(Category category);
        void delete(int id);


    }
}
