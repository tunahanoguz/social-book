using SocialBook.Application.Repositories.Users;
using SocialBook.Domain.Entities.Users;
using SocialBook.Persistence.Contexts;
using SocialBook.Persistence.Repositories.Common;

namespace SocialBook.Persistence.Repositories.Users
{
    public class UserSocialMediaReadRepository : ReadRepository<UserSocialMedia>, IUserSocialMediaReadRepository
    {
        public UserSocialMediaReadRepository(SocialBookAPIDbContext context) : base(context)
        {
        }
    }
}
