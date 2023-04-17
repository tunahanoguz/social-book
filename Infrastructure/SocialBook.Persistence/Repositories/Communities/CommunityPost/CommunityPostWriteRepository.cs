using SocialBook.Application.Repositories.Communities;
using SocialBook.Domain.Entities.Communities;
using SocialBook.Persistence.Contexts;
using SocialBook.Persistence.Repositories.Common;

namespace SocialBook.Persistence.Repositories.Communities
{
    public class CommunityPostWriteRepository : WriteRepository<CommunityPost>, ICommunityPostWriteRepository
    {
        public CommunityPostWriteRepository(SocialBookAPIDbContext context) : base(context)
        {
        }
    }
}
