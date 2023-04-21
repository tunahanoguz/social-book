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
                new AppRole { Id = "b35b86ea-8969-4121-8789-4d48b0cbab1a", Name = "Administrator", NormalizedName = "ADMINISTRATOR" },
                new AppRole { Id = "c8d734dd-3d51-41fa-b109-8672a30b183e", Name = "Editor", NormalizedName = "EDITOR" },
                new AppRole { Id = "fbbfdce6-caa7-49ae-9118-13dc98d99600", Name = "Reader", NormalizedName = "READER" }
            );
        }
    }
}
