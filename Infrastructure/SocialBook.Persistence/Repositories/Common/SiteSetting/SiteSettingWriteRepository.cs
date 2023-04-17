using SocialBook.Application.Repositories.Common;
using SocialBook.Domain.Common;
using SocialBook.Persistence.Contexts;

namespace SocialBook.Persistence.Repositories.Common
{
    public class SiteSettingWriteRepository : WriteRepository<SiteSetting>, ISiteSettingWriteRepository
    {
        public SiteSettingWriteRepository(SocialBookAPIDbContext context) : base(context)
        {
        }
    }
}
