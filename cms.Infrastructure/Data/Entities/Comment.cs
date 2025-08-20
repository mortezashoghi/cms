using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cms.Infrastructure.Data.Entities
{
    public class Comment
    {
        public int Id { get; set; }

        public string Description { get; set; }
        public Post Post { get; set; }
        public DateTime CreatedDate { get; set; }


    }
    public class commentconfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder) 
        { 
            builder.ToTable("comments");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Description).HasMaxLength(1000);
            builder.HasOne(p=>p.Post).WithMany(c=>c.comments);

        }
    }
}
