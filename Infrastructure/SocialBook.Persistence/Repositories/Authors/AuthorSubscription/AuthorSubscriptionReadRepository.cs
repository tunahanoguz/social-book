using SocialBook.Application.Repositories.Authors;
using SocialBook.Domain.Entities.Authors;
using SocialBook.Persistence.Contexts;
using SocialBook.Persistence.Repositories.Common;

namespace SocialBook.Persistence.Repositories.Authors
{
    public class AuthorSubscriptionReadRepository : ReadRepository<AuthorSubscription>, IAuthorSubscriptionReadRepository
    {
        public AuthorSubscriptionReadRepository(SocialBookAPIDbContext context) : base(context)
        {
        }
    }
}
