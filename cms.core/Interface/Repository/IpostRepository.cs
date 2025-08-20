using cms.core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cms.core.Interface.Repository
{
    public interface IpostRepository
    {
        Task<List<Post>> GetAll();
        List<Post> GetPostbyid(int id);
        int add (Post post);
        Post edit (Post post);
        void delete (int id);

    }
}
