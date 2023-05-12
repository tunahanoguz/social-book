using SocialBook.Application.Interfaces.Repositories.Books;
using SocialBook.Domain.Entities.Books;
using SocialBook.Persistence.Contexts;
using SocialBook.Persistence.Repositories.Common;

namespace SocialBook.Persistence.Repositories.Books
{
    public class BookSubscriptionWriteRepository : WriteRepository<BookSubscription>, IBookSubscriptionWriteRepository
    {
        public BookSubscriptionWriteRepository(SocialBookAPIDbContext context) : base(context)
        {
        }
    }
}
