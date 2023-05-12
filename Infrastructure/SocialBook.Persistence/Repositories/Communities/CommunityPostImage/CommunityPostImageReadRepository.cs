using SocialBook.Application.Interfaces.Repositories.Communities;
using SocialBook.Domain.Entities.Communities;
using SocialBook.Persistence.Contexts;
using SocialBook.Persistence.Repositories.Common;

namespace SocialBook.Persistence.Repositories.Communities
{
    public class CommunityPostImageReadRepository : ReadRepository<CommunityPostImage>, ICommunityPostImageReadRepository
    {
        public CommunityPostImageReadRepository(SocialBookAPIDbContext context) : base(context)
        {
        }
    }
}
