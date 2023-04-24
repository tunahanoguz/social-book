using SocialBook.Application.Repositories.Common;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Repositories.Authors
{
    public interface IAuthorReviewLikeReadRepository : IReadRepository<AuthorReviewLike>
    {
        Task<List<AuthorReviewLike>> GetAuthorReviewLikesByAuthorReviewAsync(Guid authorReviewId);
        Task<List<AuthorReviewLike>> GetAuthorReviewLikesByUserAsync(string userId);
    }
}
