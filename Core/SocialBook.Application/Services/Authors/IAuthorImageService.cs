using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Services.Authors
{
    public interface IAuthorImageService
    {
        Task<List<AuthorImage>> GetAuthorImagesByFileExtensionAsync(string extension);
        Task<List<AuthorImage>> GetAuthorImagesByAuthorAsync(Guid authorId);
        Task<bool> CreateAuthorImageAsync(AuthorImage authorImage);
        bool UpdateAuthorImage(AuthorImage authorImage);
        bool DeleteAuthorImage(AuthorImage authorImage);
    }
}
