using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Services.Authors
{
    public interface IAuthorReviewDislikeService
    {
        Task<List<AuthorReviewDislike>> GetAuthorReviewDislikesByAuthorReviewAsync(Guid authorReviewId);
        Task<List<AuthorReviewDislike>> GetAuthorReviewDislikesByUserAsync(string userId);
        Task<bool> CreateAuthorReviewDislikeAsync(AuthorReviewDislike authorReviewDislike);
        bool UpdateAuthorReviewDislike(AuthorReviewDislike authorReviewDislike);
        bool DeleteAuthorReviewDislike(AuthorReviewDislike authorReviewDislike);
    }
}
