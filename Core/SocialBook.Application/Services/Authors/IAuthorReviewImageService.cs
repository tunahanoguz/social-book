using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Services.Authors
{
    public interface IAuthorReviewImageService
    {
        Task<List<AuthorReviewImage>> GetAuthorReviewImagesByFileExtensionAsync(string extension);
        Task<List<AuthorReviewImage>> GetAuthorReviewImagesByAuthorReviewAsync(Guid authorReviewId);
        Task<bool> CreateAuthorReviewImageAsync(AuthorReviewImage authorReviewImage);
        bool UpdateAuthorReviewImage(AuthorReviewImage authorReviewImage);
        bool DeleteAuthorReviewImage(AuthorReviewImage authorReviewImage);
    }
}
