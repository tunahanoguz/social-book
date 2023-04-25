using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Services.Authors
{
    public interface IAuthorService
    {
        Task<Author> GetAuthorById(string authorId);
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
        Task<bool> CreateAuthorAsync(Author author);
        bool UpdateAuthor(Author author);
        bool DeleteAuthor(Author author);
    }
}
