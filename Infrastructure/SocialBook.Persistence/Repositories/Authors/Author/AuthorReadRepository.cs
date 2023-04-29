﻿using Microsoft.EntityFrameworkCore;
using SocialBook.Application.Filters;
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

        /// <inheritdoc />
        public async Task<List<Author>> GetAuthorsByFirstNameAsync(string firstName, PaginationFilter paginationFilter)
        {
            return await GetWhere(author => author.FirstName == firstName, false)
                .Skip((paginationFilter.PageNumber - 1) * paginationFilter.PageSize)
                .Take(paginationFilter.PageSize)
                .ToListAsync();
        }

        /// <inheritdoc />
        public async Task<List<Author>> GetAuthorsByLastNameAsync(string lastName)
        {
            return await GetWhere(author => author.LastName == lastName, false).ToListAsync();
        }

        /// <inheritdoc />
        public async Task<List<Author>> GetAuthorsByCountryOfBirthAsync(string country)
        {
            return await GetWhere(author => author.CountryOfBirth == country, false).ToListAsync();
        }

        /// <inheritdoc />
        public async Task<List<Author>> GetAuthorsByYearOfBirthAsync(int year)
        {
            return await GetWhere(author => author.DateOfBirth.Year == year, false).ToListAsync();
        }

        /// <inheritdoc />
        public async Task<List<Author>> GetAuthorsAllowedReviewAsync()
        {
            return await GetWhere(author => author.IsAllowedReview == true, false).ToListAsync();
        }

        /// <inheritdoc />
        public async Task<List<Author>> GetAuthorsNotAllowedReviewAsync()
        {
            return await GetWhere(author => author.IsAllowedReview == false, false).ToListAsync();
        }

        /// <inheritdoc />
        public async Task<List<Author>> GetAuthorsAllowedRecommendationAsync()
        {
            return await GetWhere(author => author.IsAllowedRecommendation == true, false).ToListAsync();
        }

        /// <inheritdoc />
        public async Task<List<Author>> GetAuthorsNotAllowedRecommendationAsync()
        {
            return await GetWhere(author => author.IsAllowedRecommendation == false, false).ToListAsync();
        }

        /// <inheritdoc />
        public async Task<List<Author>> GetAuthorsAllowedSubscriptionAsync()
        {
            return await GetWhere(author => author.IsAllowedSubscription == true, false).ToListAsync();
        }

        /// <inheritdoc />
        public async Task<List<Author>> GetAuthorsNotAllowedSubscriptionAsync()
        {
            return await GetWhere(author => author.IsAllowedSubscription == false, false).ToListAsync();
        }

        /// <inheritdoc />
        public async Task<List<Author>> GetAuthorsByCreatorUserAsync(string userId)
        {
            return await GetWhere(author => author.CreatorUserId == userId, false).ToListAsync();
        }
    }
}
