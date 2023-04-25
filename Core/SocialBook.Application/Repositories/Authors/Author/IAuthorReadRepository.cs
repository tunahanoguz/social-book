using SocialBook.Application.Repositories.Common;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Repositories.Authors
{
    public interface IAuthorReadRepository : IReadRepository<Author>
    {
        Task<List<Author>> GetAuthorsByFirstNameAsync(string firstName);
        Task<List<Author>> GetAuthorsByLastNameAsync(string lastName);
        Task<List<Author>> GetAuthorsByCountryOfBirthAsync(string country);
        Task<List<Author>> GetAuthorsByYearOfBirthAsync(int year);
        Task<List<Author>> GetAuthorsAllowedReviewAsync();
        Task<List<Author>> GetAuthorsNotAllowedReviewAsync();
        Task<List<Author>> GetAuthorsAllowedRecommendationAsync();
        Task<List<Author>> GetAuthorsNotAllowedRecommendationAsync();
        Task<List<Author>> GetAuthorsAllowedSubscriptionAsync();
        Task<List<Author>> GetAuthorsNotAllowedSubscriptionAsync();
        Task<List<Author>> GetAuthorsByCreatorUserAsync(string userId);
    }
}
