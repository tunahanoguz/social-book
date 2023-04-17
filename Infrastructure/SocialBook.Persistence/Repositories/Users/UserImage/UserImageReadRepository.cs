using SocialBook.Application.Repositories.Users;
using SocialBook.Domain.Entities.Users;
using SocialBook.Persistence.Contexts;
using SocialBook.Persistence.Repositories.Common;

namespace SocialBook.Persistence.Repositories.Users
{
    public class UserImageReadRepository : ReadRepository<UserImage>, IUserImageReadRepository
    {
        public UserImageReadRepository(SocialBookAPIDbContext context) : base(context)
        {
        }
    }
}
