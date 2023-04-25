using Microsoft.EntityFrameworkCore;
using SocialBook.Application.Repositories.Authors;
using SocialBook.Domain.Entities.Authors;
using SocialBook.Persistence.Contexts;
using SocialBook.Persistence.Repositories.Common;

namespace SocialBook.Persistence.Repositories.Authors
{
    public class AuthorReadRepository : ReadRepository<Author>, IAuthorReadRepository
    {
        public AuthorReadRepository(SocialBookAPIDbContext context) : base(context)
        {
        }

        /// <summary>
        /// Get all authors with the first name provided as a parameter
        /// </summary>
        /// <param name="firstName">The first name of the author</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the authors with the first name provided as a parameter
        /// </returns>
        public async Task<List<Author>> GetAuthorsByFirstNameAsync(string firstName)
        {
            return await GetWhere(author => author.FirstName == firstName, false).ToListAsync();
        }

        /// <summary>
        /// Get all authors with the last name provided as a parameter
        /// </summary>
        /// <param name="lastName">The last name of the author</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the authors with the last name provided as a parameter
        /// </returns>
        public async Task<List<Author>> GetAuthorsByLastNameAsync(string lastName)
        {
            return await GetWhere(author => author.LastName == lastName, false).ToListAsync();
        }

        /// <summary>
        /// Get all authors born in the country provided as a parameter
        /// </summary>
        /// <param name="country">The country where the author was born</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the authors born in the country provided as a parameter
        /// </returns>
        public async Task<List<Author>> GetAuthorsByCountryOfBirthAsync(string country)
        {
            return await GetWhere(author => author.CountryOfBirth == country, false).ToListAsync();
        }

        /// <summary>
        /// Get all authors born in the year provided as a parameter
        /// </summary>
        /// <param name="year">The year where the author was born</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the authors born in the year provided as a parameter
        /// </returns>
        public async Task<List<Author>> GetAuthorsByYearOfBirthAsync(int year)
        {
            return await GetWhere(author => author.DateOfBirth.Year == year, false).ToListAsync();
        }

        /// <summary>
        /// Get all authors allowed to have reviews published about them
        /// </summary>
        /// <returns>
        /// /// A task that represents the asynchronous operation
        /// The task result contains the authors allowed to have reviews published about them
        /// </returns>
        public async Task<List<Author>> GetAuthorsAllowedReviewAsync()
        {
            return await GetWhere(author => author.IsAllowedReview == true, false).ToListAsync();
        }

        /// <summary>
        /// Get all authors not allowed to have reviews published about them
        /// </summary>
        /// <returns>
        /// /// A task that represents the asynchronous operation
        /// The task result contains the authors not allowed to have reviews published about them
        /// </returns>
        public async Task<List<Author>> GetAuthorsNotAllowedReviewAsync()
        {
            return await GetWhere(author => author.IsAllowedReview == false, false).ToListAsync();
        }

        /// <summary>
        /// Get all authors allowed to be recommended by users to other users
        /// </summary>
        /// <returns>
        /// /// A task that represents the asynchronous operation
        /// The task result contains the authors allowed to be recommended by users to other users
        /// </returns>
        public async Task<List<Author>> GetAuthorsAllowedRecommendationAsync()
        {
            return await GetWhere(author => author.IsAllowedRecommendation == true, false).ToListAsync();
        }

        /// <summary>
        /// Get all authors not allowed to be recommended by users to other users
        /// </summary>
        /// <returns>
        /// /// A task that represents the asynchronous operation
        /// The task result contains the authors not allowed to be recommended by users to other users
        /// </returns>
        public async Task<List<Author>> GetAuthorsNotAllowedRecommendationAsync()
        {
            return await GetWhere(author => author.IsAllowedRecommendation == false, false).ToListAsync();
        }

        /// <summary>
        /// Get all authors who are allowed to be subscribed to by users
        /// </summary>
        /// <returns>
        /// /// A task that represents the asynchronous operation
        /// The task result contains the authors who are allowed to be subscribed to by users
        /// </returns>
        public async Task<List<Author>> GetAuthorsAllowedSubscriptionAsync()
        {
            return await GetWhere(author => author.IsAllowedSubscription == true, false).ToListAsync();
        }

        /// <summary>
        /// Get all authors who are not allowed to be subscribed to by users
        /// </summary>
        /// <returns>
        /// /// A task that represents the asynchronous operation
        /// The task result contains the authors who are not allowed to be subscribed to by users
        /// </returns>
        public async Task<List<Author>> GetAuthorsNotAllowedSubscriptionAsync()
        {
            return await GetWhere(author => author.IsAllowedSubscription == false, false).ToListAsync();
        }

        /// <summary>
        /// Get all authors belonging to the user whose ID is provided as a parameter
        /// </summary>
        /// <param name="userId">The creator user identifier</param>
        /// <returns>
        /// /// A task that represents the asynchronous operation
        /// The task result contains the authors belonging to the user whose ID is provided as a parameter
        /// </returns>
        public async Task<List<Author>> GetAuthorsByCreatorUserAsync(string userId)
        {
            return await GetWhere(author => author.CreatorUserId == userId, false).ToListAsync();
        }
    }
}
