using Blogden.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blogden.Repository.Configurations
{
    public class BlogConfiguration : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Title).IsRequired().HasMaxLength(64);

            builder.Property(x => x.Content).IsRequired();

            builder.HasOne(x => x.Author).WithMany(x => x.Blogs).HasForeignKey(x => x.AuthorId);

            builder.HasMany(x => x.Comments).WithOne(x => x.Blog).HasForeignKey(x => x.BlogId);
        }
    }
}
