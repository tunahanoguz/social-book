using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Services.Authors
{
    public interface IAuthorReviewLikeService
    {
        Task<List<AuthorReviewLike>> GetAuthorReviewLikesByAuthorReviewAsync(Guid authorReviewId);
        Task<List<AuthorReviewLike>> GetAuthorReviewLikesByUserAsync(string userId);
        Task<bool> CreateAuthorReviewLikeAsync(AuthorReviewLike authorReviewLike);
        bool UpdateAuthorReviewLike(AuthorReviewLike authorReviewLike);
        bool DeleteAuthorReviewLike(AuthorReviewLike authorReviewLike);
    }
}
