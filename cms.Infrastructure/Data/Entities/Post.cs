using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cms.Infrastructure.Data.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public string title { get; set; }
        public int categoryid { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public int userid { get; set; }

        public DateTime Createddate { get; set; }
        public DateTime Updateddate { get; set; }
        public User User { get; set; }
        public Category Category { get; set; }
        public IEnumerable<Comment> comments{get;set;}

    }

    public class postConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.ToTable("posts");
            builder.HasKey(x=>x.Id);

        }
    }
}
