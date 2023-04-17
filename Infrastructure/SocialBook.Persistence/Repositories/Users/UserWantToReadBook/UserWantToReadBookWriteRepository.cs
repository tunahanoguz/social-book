using SocialBook.Application.Repositories.Users;
using SocialBook.Domain.Entities.Users;
using SocialBook.Persistence.Contexts;
using SocialBook.Persistence.Repositories.Common;

namespace SocialBook.Persistence.Repositories.Users
{
    public class UserWantToReadBookWriteRepository : WriteRepository<UserWantToReadBook>, IUserWantToReadBookWriteRepository
    {
        public UserWantToReadBookWriteRepository(SocialBookAPIDbContext context) : base(context)
        {
        }
    }
}
