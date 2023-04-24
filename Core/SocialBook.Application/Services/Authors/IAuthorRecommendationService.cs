using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Services.Authors
{
    public interface IAuthorRecommendationService
    {
        Task<List<AuthorRecommendation>> GetAuthorRecommendationsByAuthorAsync(Guid authorId);
        Task<List<AuthorRecommendation>> GetAuthorRecommendationsByRecommenderUserAsync(string recommenderUserId);
        Task<List<AuthorRecommendation>> GetAuthorRecommendationsByRecipientUserAsync(string recipientUserId);
        Task<bool> CreateAuthorRecommendationAsync(AuthorRecommendation authorRecommendation);
        bool UpdateRecommendationAuthor(AuthorRecommendation authorRecommendation);
        bool DeleteRecommendationAuthor(AuthorRecommendation authorRecommendation);
    }
}
