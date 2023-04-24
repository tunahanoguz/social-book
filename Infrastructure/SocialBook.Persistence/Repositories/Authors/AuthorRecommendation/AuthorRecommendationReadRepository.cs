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

        public async Task<List<AuthorRecommendation>> GetAuthorRecommendationsByAuthorAsync(Guid authorId)
        {
            return await GetWhere(a => a.AuthorId == authorId).ToListAsync();
        }

        public async Task<List<AuthorRecommendation>> GetAuthorRecommendationsByRecommenderUserAsync(string recommenderUserId)
        {
            return await GetWhere(a => a.RecommenderUserId == recommenderUserId).ToListAsync();
        }

        public async Task<List<AuthorRecommendation>> GetAuthorRecommendationsByRecipientUserAsync(string recipientUserId)
        {
            return await GetWhere(a => a.RecipientUserId == recipientUserId).ToListAsync();
        }
    }
}
