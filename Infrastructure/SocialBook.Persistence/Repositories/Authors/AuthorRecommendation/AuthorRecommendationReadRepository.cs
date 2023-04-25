using Microsoft.EntityFrameworkCore;
using SocialBook.Application.Repositories.Authors;
using SocialBook.Domain.Entities.Authors;
using SocialBook.Persistence.Contexts;
using SocialBook.Persistence.Repositories.Common;

namespace SocialBook.Persistence.Repositories.Authors
{
    public class AuthorRecommendationReadRepository : ReadRepository<AuthorRecommendation>, IAuthorRecommendationReadRepository
    {
        public AuthorRecommendationReadRepository(SocialBookAPIDbContext context) : base(context)
        {
        }

        /// <summary>
        /// Get author recommendations belonging to the author whose ID is provided as a parameter
        /// </summary>
        /// <param name="authorId">The author identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author recommendations belonging to the author whose ID is provided as a parameter
        /// </returns>
        public async Task<List<AuthorRecommendation>> GetAuthorRecommendationsByAuthorAsync(Guid authorId)
        {
            return await GetWhere(a => a.AuthorId == authorId).ToListAsync();
        }

        /// <summary>
        /// Get author recommendations belonging to the recommender user whose ID is provided as a parameter
        /// </summary>
        /// <param name="recommenderUserId">The recommender user identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author recommendations belonging to the recommender user whose ID is provided as a parameter
        /// </returns>
        public async Task<List<AuthorRecommendation>> GetAuthorRecommendationsByRecommenderUserAsync(string recommenderUserId)
        {
            return await GetWhere(a => a.RecommenderUserId == recommenderUserId).ToListAsync();
        }

        /// <summary>
        /// Get author recommendations belonging to the recipient user whose ID is provided as a parameter
        /// </summary>
        /// <param name="recipientUserId">The recipient user identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author recommendations belonging to the recipient user whose ID is provided as a parameter
        /// </returns>
        public async Task<List<AuthorRecommendation>> GetAuthorRecommendationsByRecipientUserAsync(string recipientUserId)
        {
            return await GetWhere(a => a.RecipientUserId == recipientUserId).ToListAsync();
        }
    }
}
