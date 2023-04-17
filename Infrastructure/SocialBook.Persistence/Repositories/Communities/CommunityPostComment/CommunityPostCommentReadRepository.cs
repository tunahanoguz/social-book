using SocialBook.Application.Repositories.Communities;
using SocialBook.Domain.Entities.Communities;
using SocialBook.Persistence.Contexts;
using SocialBook.Persistence.Repositories.Common;

namespace SocialBook.Persistence.Repositories.Communities
{
    public class CommunityPostCommentReadRepository : ReadRepository<CommunityPostComment>, ICommunityPostCommentReadRepository
    {
        public CommunityPostCommentReadRepository(SocialBookAPIDbContext context) : base(context)
        {
        }
    }
}
