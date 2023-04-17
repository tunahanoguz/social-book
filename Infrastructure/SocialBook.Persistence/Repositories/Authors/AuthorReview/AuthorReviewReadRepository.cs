using SocialBook.Application.Repositories.Authors;
using SocialBook.Domain.Entities.Authors;
using SocialBook.Persistence.Contexts;
using SocialBook.Persistence.Repositories.Common;

namespace SocialBook.Persistence.Repositories.Authors
{
    public class AuthorReviewReadRepository : ReadRepository<AuthorReview>, IAuthorReviewReadRepository
    {
        public AuthorReviewReadRepository(SocialBookAPIDbContext context) : base(context)
        {
        }
    }
}
