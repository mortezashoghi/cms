using cms.core.Domain;
using cms.core.Interface.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cms.Infrastructure.Data.Repositoreis
{
    public class categoryRepository : IcategoryRepository
    {
        private cmsdbcontext _cmsdbcontext;

        public categoryRepository(cmsdbcontext cmsdbcontext) {
        _cmsdbcontext= cmsdbcontext;
        }

        public async Task<int> add(Category category)
        {
            _cmsdbcontext.Add(category);
            await _cmsdbcontext.SaveChangesAsync();
            return category.Id;
        }

        public void delete(int id)
        {
            _cmsdbcontext.categories.Where(p => p.Id == id).ExecuteDelete();
        }

        public Task<Category> edit(Category category,int cid)
        {
            throw new NotImplementedException();
        }

        public Task<List<Category>> GetAllCategories()
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetCategory(string categoryName)
        {
            throw new NotImplementedException();
        }
    }
}
