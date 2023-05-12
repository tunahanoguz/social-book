using SocialBook.Application.Interfaces.Repositories.Authors;
using SocialBook.Domain.Entities.Authors;
using SocialBook.Persistence.Contexts;
using SocialBook.Persistence.Repositories.Common;

namespace SocialBook.Persistence.Repositories.Authors
{
    public class AuthorGenreReadRepository : ReadRepository<AuthorGenre>, IAuthorGenreReadRepository
    {
        public AuthorGenreReadRepository(SocialBookAPIDbContext context) : base(context)
        {
        }
    }
}
