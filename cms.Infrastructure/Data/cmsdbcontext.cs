using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Design;
using cms.Infrastructure.Data.Entities;

namespace cms.Infrastructure.Data
{
    public class cmsdbcontext : DbContext
    {
        public DbSet<Post> posts { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Comment> comments{ get; set; }
        public DbSet<User> users { get; set; }

        public cmsdbcontext(DbContextOptions<cmsdbcontext> options) : base(options) {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {         
                modelBuilder.ApplyConfiguration(new CategoryConfiguraion());
                modelBuilder.ApplyConfiguration(new commentconfiguration());
                modelBuilder.ApplyConfiguration(new postConfiguration());
                modelBuilder.ApplyConfiguration(new userconfiguration());
        }
    }

    public class CmsDbcontextFactory : IDesignTimeDbContextFactory<cmsdbcontext>
    {
        public cmsdbcontext CreateDbContext(string[] args) {

            Console.WriteLine("=== Design-Time DbContext Factory ===");
            Console.WriteLine("Current Directory: " + Directory.GetCurrentDirectory());

            var optionBuilder = new DbContextOptionsBuilder<cmsdbcontext>();
                optionBuilder.UseSqlServer(@"Server=.\SQLExpress;Database=cmsdb;Trusted_Connection=True;TrustServerCertificate=true;");
            
            return new cmsdbcontext(optionBuilder.Options);
        }
    }
}
