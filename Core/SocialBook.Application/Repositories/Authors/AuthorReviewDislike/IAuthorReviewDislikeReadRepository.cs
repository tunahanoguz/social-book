using SocialBook.Application.Repositories.Common;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Repositories.Authors
{
    public interface IAuthorReviewDislikeReadRepository : IReadRepository<AuthorReviewDislike>
    {
        Task<List<AuthorReviewDislike>> GetAuthorReviewDislikesByAuthorReviewAsync(Guid authorReviewId);
        Task<List<AuthorReviewDislike>> GetAuthorReviewDislikesByUserAsync(string userId);
    }
}
