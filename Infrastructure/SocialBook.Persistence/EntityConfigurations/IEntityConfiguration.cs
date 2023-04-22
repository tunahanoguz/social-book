using Microsoft.EntityFrameworkCore;
using SocialBook.Domain.Entities.Authors;
using SocialBook.Domain.Entities.Common;
using SocialBook.Domain.Entities.Identity;

namespace SocialBook.Persistence.EntityConfigurations
{
    public interface IEntityConfiguration
    {
        IEntityTypeConfiguration<AppUser> AppUserConfiguration { get; set; }
        IEntityTypeConfiguration<AppRole> AppRoleConfiguration { get; set; }
        IEntityTypeConfiguration<AppUserRole> AppUserRoleConfiguration { get; set; }
        IEntityTypeConfiguration<SiteSetting> SiteSettingConfiguration { get; set; }
        IEntityTypeConfiguration<Genre> GenreConfiguration { get; set; }
        IEntityTypeConfiguration<Author> AuthorConfiguration { get; set; }
    }
}
