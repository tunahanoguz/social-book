using SocialBook.Application.Repositories.Common;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Repositories.Authors
{
    public interface IAuthorImageReadRepository : IReadRepository<AuthorImage>
    {
        Task<List<AuthorImage>> GetAuthorImagesByFileExtensionAsync(string extension);
        Task<List<AuthorImage>> GetAuthorImagesByAuthorAsync(Guid authorId);
    }
}
