using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Services.Authors
{
    public interface IAuthorRecommendationService
    {
        Task<List<AuthorRecommendation>> GetAuthorRecommendationsByAuthorAsync(Guid authorId);
        Task<List<AuthorRecommendation>> GetAuthorRecommendationsByRecommenderUserAsync(string recommenderUserId);
        Task<List<AuthorRecommendation>> GetAuthorRecommendationsByRecipientUserAsync(string recipientUserId);
        Task<bool> CreateAuthorRecommendationAsync(AuthorRecommendation author);
        bool UpdateRecommendationAuthor(AuthorRecommendation author);
        bool DeleteRecommendationAuthor(AuthorRecommendation author);
    }
}
