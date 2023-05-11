using SocialBook.Application.Interfaces.Repositories.Users;
using SocialBook.Domain.Entities.Users;
using SocialBook.Persistence.Contexts;
using SocialBook.Persistence.Repositories.Common;

namespace SocialBook.Persistence.Repositories.Users
{
    public class UserSocialMediaPlatformReadRepository : ReadRepository<UserSocialMediaPlatform>, IUserSocialMediaPlatformReadRepository
    {
        public UserSocialMediaPlatformReadRepository(SocialBookAPIDbContext context) : base(context)
        {
        }
    }
}
