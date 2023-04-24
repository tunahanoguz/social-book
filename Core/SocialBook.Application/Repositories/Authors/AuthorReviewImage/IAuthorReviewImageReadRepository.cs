using SocialBook.Application.Repositories.Common;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Repositories.Authors
{
    public interface IAuthorReviewImageReadRepository : IReadRepository<AuthorReviewImage>
    {
        Task<List<AuthorReviewImage>> GetAuthorReviewImagesByFileExtensionAsync(string extension);
        Task<List<AuthorReviewImage>> GetAuthorReviewImagesByAuthorReviewAsync(Guid authorReviewId);
    }
}
