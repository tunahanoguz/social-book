using SocialBook.Application.Interfaces.Repositories.Common;
using SocialBook.Domain.Entities.Books;

namespace SocialBook.Application.Interfaces.Repositories.Books
{
    public interface IBookWriteRepository : IWriteRepository<Book>
    {
    }
}
