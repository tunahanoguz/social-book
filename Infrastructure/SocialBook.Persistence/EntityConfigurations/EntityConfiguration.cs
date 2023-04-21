using Microsoft.EntityFrameworkCore;
using SocialBook.Domain.Entities.Identity;
using SocialBook.Persistence.EntityConfigurations.Identity;

namespace SocialBook.Persistence.EntityConfigurations
{
    public class EntityConfiguration : IEntityConfiguration
    {
        public IEntityTypeConfiguration<AppUser> AppUserConfiguration { get; set; } = new AppUserConfiguration();
    }
}
