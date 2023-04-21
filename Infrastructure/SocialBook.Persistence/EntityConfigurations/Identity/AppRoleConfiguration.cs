using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialBook.Domain.Entities.Identity;

namespace SocialBook.Persistence.EntityConfigurations.Identity
{
    public class AppRoleConfiguration : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            builder.HasData(
                new AppRole { Id = new Guid().ToString(), Name = "Administrator", NormalizedName = "ADMINISTRATOR" },
                new AppRole { Id = new Guid().ToString(), Name = "Editor", NormalizedName = "EDITOR" },
                new AppRole { Id = new Guid().ToString(), Name = "Reader", NormalizedName = "READER" }
            );
        }
    }
}
