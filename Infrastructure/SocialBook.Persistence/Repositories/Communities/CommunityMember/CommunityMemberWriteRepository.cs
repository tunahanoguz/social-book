using SocialBook.Application.Repositories.Communities;
using SocialBook.Domain.Entities.Communities;
using SocialBook.Persistence.Contexts;
using SocialBook.Persistence.Repositories.Common;

namespace SocialBook.Persistence.Repositories.Communities
{
    public class CommunityMemberWriteRepository : WriteRepository<CommunityMember>, ICommunityMemberWriteRepository
    {
        public CommunityMemberWriteRepository(SocialBookAPIDbContext context) : base(context)
        {
        }
    }
}
