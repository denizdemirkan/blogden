using Blogden.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blogden.Repository.Configurations
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Title).IsRequired().HasMaxLength(64);

            builder.Property(x => x.Content).IsRequired();

            builder.Property(x => x.Email).IsRequired().HasMaxLength(64);

            builder.Property(x => x.Name).IsRequired().HasMaxLength(32);

            builder.HasOne(x => x.Blog).WithMany(x => x.Comments).HasForeignKey(x => x.BlogId);

        }
    }
}
