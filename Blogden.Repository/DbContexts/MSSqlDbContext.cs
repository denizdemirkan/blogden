using Blogden.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Blogden.Repository.DbContexts
{
    public class MSSqlDbContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public MSSqlDbContext(DbContextOptions<MSSqlDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Search "Configurations" in the current Assembly (application)
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
