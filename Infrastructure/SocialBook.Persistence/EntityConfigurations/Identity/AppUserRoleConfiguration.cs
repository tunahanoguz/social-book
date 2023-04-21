using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialBook.Domain.Entities.Identity;

namespace SocialBook.Persistence.EntityConfigurations.Identity
{
    public class AppUserRoleConfiguration : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            builder.HasData(
                new AppUserRole { UserId = "6b695933-0170-4908-a56c-25d5e5c2d005", RoleId = "b35b86ea-8969-4121-8789-4d48b0cbab1a" },
                new AppUserRole { UserId = "651e4582-f6e2-46b9-a4e4-8e8064e31ba3", RoleId = "c8d734dd-3d51-41fa-b109-8672a30b183e" },
                new AppUserRole { UserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f", RoleId = "fbbfdce6-caa7-49ae-9118-13dc98d99600" },
                new AppUserRole { UserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1", RoleId = "fbbfdce6-caa7-49ae-9118-13dc98d99600" }
            );
        }
    }
}
