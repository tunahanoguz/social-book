using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialBook.Domain.Entities.Common;

namespace SocialBook.Persistence.EntityConfigurations.Common
{
    public class SiteSettingConfiguration : IEntityTypeConfiguration<SiteSetting>
    {
        public void Configure(EntityTypeBuilder<SiteSetting> builder)
        {
            builder.HasData(
                new SiteSetting
                {
                    Id = new Guid("43a2057c-6ed8-4c12-ad5d-1fdd37787296"),
                    Title = "Social Book",
                    MetaDescription = "Meta description for social book",
                    MetaKeywords = "Meta keywords for social book",
                    PageTitleSeperator = "-",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                }
            );
        }
    }
}
