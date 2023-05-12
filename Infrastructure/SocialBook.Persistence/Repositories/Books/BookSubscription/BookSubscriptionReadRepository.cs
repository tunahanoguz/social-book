using SocialBook.Application.Interfaces.Repositories.Books;
using SocialBook.Domain.Entities.Books;
using SocialBook.Persistence.Contexts;
using SocialBook.Persistence.Repositories.Common;

namespace SocialBook.Persistence.Repositories.Books
{
    public class BookSubscriptionReadRepository : ReadRepository<BookSubscription>, IBookSubscriptionReadRepository
    {
        public BookSubscriptionReadRepository(SocialBookAPIDbContext context) : base(context)
        {
        }
    }
}
