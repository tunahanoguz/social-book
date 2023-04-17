using SocialBook.Application.Repositories.Common;
using SocialBook.Domain.Entities.Common;
using SocialBook.Persistence.Contexts;

namespace SocialBook.Persistence.Repositories.Common
{
    public class SiteSettingReadRepository : ReadRepository<SiteSetting>, ISiteSettingReadRepository
    {
        public SiteSettingReadRepository(SocialBookAPIDbContext context) : base(context)
        {
        }
    }
}
