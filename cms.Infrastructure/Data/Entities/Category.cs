using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cms.Infrastructure.Data.Entities
{
    public  class Category
    {
        public int Id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
    }
    public class CategoryConfiguraion : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("categories");
            builder.HasKey(c => c.Id);
            builder.Property(p=>p.description).HasMaxLength(1000);
            
        }
    }

    
}
