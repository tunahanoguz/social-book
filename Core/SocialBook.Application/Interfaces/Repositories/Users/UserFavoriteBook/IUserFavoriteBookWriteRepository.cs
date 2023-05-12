using SocialBook.Application.Interfaces.Repositories.Common;
using SocialBook.Domain.Entities.Users;

namespace SocialBook.Application.Interfaces.Repositories.Users
{
    public interface IUserFavoriteBookWriteRepository : IWriteRepository<UserFavoriteBook>
    {
    }
}
