using SocialBook.Application.Interfaces.Repositories.Users;
using SocialBook.Domain.Entities.Users;
using SocialBook.Persistence.Contexts;
using SocialBook.Persistence.Repositories.Common;

namespace SocialBook.Persistence.Repositories.Users
{
    public class UserFavoriteBookWriteRepository : WriteRepository<UserFavoriteBook>, IUserFavoriteBookWriteRepository
    {
        public UserFavoriteBookWriteRepository(SocialBookAPIDbContext context) : base(context)
        {
        }
    }
}
