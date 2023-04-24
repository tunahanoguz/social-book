using SocialBook.Application.Repositories.Common;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Repositories.Authors
{
    public interface IAuthorReviewReadRepository : IReadRepository<AuthorReview>
    {
        Task<List<AuthorReview>> GetAuthorReviewsByRatingAsync(int rating);
        Task<List<AuthorReview>> GetAuthorReviewsByAuthorAsync(Guid authorId);
        Task<List<AuthorReview>> GetAuthorReviewsByUserAsync(string userId);
    }
}
