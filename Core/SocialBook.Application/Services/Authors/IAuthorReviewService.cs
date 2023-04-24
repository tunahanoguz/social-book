using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Services.Authors
{
    public interface IAuthorReviewService
    {
        Task<List<AuthorReview>> GetAuthorReviewsByRatingAsync(int rating);
        Task<List<AuthorReview>> GetAuthorReviewsByAuthorAsync(Guid authorId);
        Task<List<AuthorReview>> GetAuthorReviewsByUserAsync(string userId);
        Task<bool> CreateAuthorReviewAsync(AuthorReview author);
        bool UpdateAuthorReview(AuthorReview author);
        bool DeleteAuthorReview(AuthorReview author);
    }
}
