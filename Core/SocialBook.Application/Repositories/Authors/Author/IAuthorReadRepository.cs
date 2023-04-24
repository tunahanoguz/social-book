using SocialBook.Application.Repositories.Common;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Repositories.Authors
{
    public interface IAuthorReadRepository : IReadRepository<Author>
    {
        Task<List<Author>> GetAllAuthorsByFirstNameAsync(string firstName);
        Task<List<Author>> GetAllAuthorsByLastNameAsync(string lastName);
        Task<List<Author>> GetAllAuthorsByCountryOfBirthAsync(string country);
        Task<List<Author>> GetAllAuthorsByYearOfBirthAsync(int year);
        Task<List<Author>> GetAllAuthorsAllowedReviewAsync();
        Task<List<Author>> GetAllAuthorsNotAllowedReviewAsync();
        Task<List<Author>> GetAllAuthorsAllowedRecommendationAsync();
        Task<List<Author>> GetAllAuthorsNotAllowedRecommendationAsync();
        Task<List<Author>> GetAllAuthorsAllowedSubscriptionAsync();
        Task<List<Author>> GetAllAuthorsNotAllowedSubscriptionAsync();
        Task<List<Author>> GetAllAuthorsByCreatorUserAsync(string userId);
    }
}
