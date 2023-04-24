using SocialBook.Application.Repositories.Common;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Repositories.Authors
{
    public interface IAuthorRecommendationReadRepository : IReadRepository<AuthorRecommendation>
    {
        Task<List<AuthorRecommendation>> GetAuthorRecommendationsByAuthorAsync(Guid authorId);
        Task<List<AuthorRecommendation>> GetAuthorRecommendationsByRecommenderUserAsync(string recommenderUserId);
        Task<List<AuthorRecommendation>> GetAuthorRecommendationsByRecipientUserAsync(string recipientUserId);
    }
}
