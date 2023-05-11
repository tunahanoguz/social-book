using SocialBook.Application.Interfaces.Repositories.Common;
using SocialBook.Domain.Entities.Common;
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
