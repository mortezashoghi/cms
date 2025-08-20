using cms.core.Interface.Repository;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace cms.Infrastructure.Data.Repositoreis
{
    public class PostRepository : IpostRepository
    {
        public cmsdbcontext _cmsdbcontext { get; }

        public PostRepository(cmsdbcontext cmsdbcontext)
        {
            _cmsdbcontext = cmsdbcontext;
        }

        public async Task<List<core.Domain.Post>> GetAll()
        {
            return await( _cmsdbcontext.posts.Select(p => new core.Domain.Post
            {
                Id = p.Id,
                title = p.title,
                categoryid = p.categoryid,
                Description = p.Description,
                Author = p.Author,
                userid = p.userid,
                Createddate = p.Createddate,
                Updateddate = p.Updateddate
            }).ToListAsync());
        }

        public List<core.Domain.Post> GetPostbyid(int id)
        {
            return _cmsdbcontext.posts.Where(p => p.Id == id).Select(p => new core.Domain.Post
            {
                Id = p.Id,
                title = p.title,
                categoryid = p.categoryid,
                Description=p.Description,
                Author=p.Author,
                userid=p.userid,
                Createddate = p.Createddate,
                Updateddate = p.Updateddate
            }).ToList();
        }

        public int add(core.Domain.Post post)
        {
            var postmodel = new Infrastructure.Data.Entities.Post { 
                Id = post.Id,
                title = post.title,
                categoryid = post.categoryid,
                Description = post.Description,
                Author = post.Author,
                userid = post.userid,
                Createddate = post.Createddate,
                Updateddate = post.Updateddate
                };
            _cmsdbcontext.posts.Add(postmodel);
            _cmsdbcontext.SaveChanges();
            return postmodel.Id;

        }

        public core.Domain.Post edit(core.Domain.Post post)
        {
            throw new NotImplementedException();
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
