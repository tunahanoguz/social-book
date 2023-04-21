using Microsoft.EntityFrameworkCore;
using SocialBook.Domain.Entities.Identity;

namespace SocialBook.Persistence.EntityConfigurations
{
    public interface IEntityConfiguration
    {
        IEntityTypeConfiguration<AppUser> AppUserConfiguration { get; set; }
        IEntityTypeConfiguration<AppRole> AppRoleConfiguration { get; set; }
    }
}
