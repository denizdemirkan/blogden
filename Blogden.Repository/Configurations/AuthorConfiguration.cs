using Blogden.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blogden.Repository.Configurations
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(32);

            builder.Property(x => x.LastName).IsRequired().HasMaxLength(32);

            builder.Property(x => x.Password).IsRequired().HasMaxLength(64);

            builder.Property(x => x.Email).IsRequired().HasMaxLength(64);

            builder.ToTable(nameof(Author));

            builder.HasMany(x => x.Blogs).WithOne(x => x.Author).HasForeignKey(x => x.AuthorId);
        }
    }
}
