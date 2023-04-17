using SocialBook.Application.Repositories.Books;
using SocialBook.Domain.Entities.Books;
using SocialBook.Persistence.Contexts;
using SocialBook.Persistence.Repositories.Common;

namespace SocialBook.Persistence.Repositories.Books
{
    public class BookReviewLikeReadRepository : ReadRepository<BookReviewLike>, IBookReviewLikeReadRepository
    {
        public BookReviewLikeReadRepository(SocialBookAPIDbContext context) : base(context)
        {
        }
    }
}
