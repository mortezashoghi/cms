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
        Task<Category> GetCategory(int id);
        Task<Category> GetCategory(string categoryName);
        Task<List<Category>> GetAllCategories();
        Task<int> add(Category category);
        Task<Category> edit(Category category, int cid);
        void delete(int id);


    }
}
