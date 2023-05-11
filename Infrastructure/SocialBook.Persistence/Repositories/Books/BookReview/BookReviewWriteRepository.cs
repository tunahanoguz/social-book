using SocialBook.Application.Interfaces.Repositories.Books;
using SocialBook.Domain.Entities.Books;
using SocialBook.Persistence.Contexts;
using SocialBook.Persistence.Repositories.Common;

namespace SocialBook.Persistence.Repositories.Books
{
    public class BookReviewWriteRepository : WriteRepository<BookReview>, IBookReviewWriteRepository
    {
        public BookReviewWriteRepository(SocialBookAPIDbContext context) : base(context)
        {
        }
    }
}
