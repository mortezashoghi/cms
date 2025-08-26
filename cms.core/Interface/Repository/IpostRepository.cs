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
        Task<List<Post>> GetPostbyid(int id);
        Task<int> add (Post post);
        Task<Post> edit (Post post,int postid);
        void delete (int id);

    }
}
