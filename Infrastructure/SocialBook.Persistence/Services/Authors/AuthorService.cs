using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SocialBook.Application.DTOs.Authors.Author;
using SocialBook.Application.Filters;
using SocialBook.Application.Repositories.Authors;
using SocialBook.Application.Results;
using SocialBook.Application.Services.Authors;
using SocialBook.Application.Services.Common;
using SocialBook.Domain.Entities.Authors;
using System.Net;

namespace SocialBook.Persistence.Services.Authors
{
    public class AuthorService : IAuthorService
    {
        private readonly IMapper _mapper;
        private readonly IAuthorReadRepository _authorReadRepository;
        private readonly IAuthorWriteRepository _authorWriteRepository;
        private readonly IPaginationService _paginationService;

        public AuthorService(IMapper mapper,
            IAuthorReadRepository authorReadRepository,
            IAuthorWriteRepository authorWriteRepository,
            IPaginationService paginationService)
        {
            _mapper = mapper;
            _authorReadRepository = authorReadRepository;
            _authorWriteRepository = authorWriteRepository;
            _paginationService = paginationService;
        }

        /// <inheritdoc />
        public async Task<Author> GetAuthorById(string authorId)
        {
            if (authorId == null) { throw new ArgumentNullException(nameof(authorId)); };

            return await _authorReadRepository.GetByIdAsync(authorId, false);
        }

        /// <inheritdoc />
        public async Task<IPaginatedDataResult<AuthorDto>> GetAuthorsByFirstNameAsync(string firstName, PaginationFilter paginationFilter)
        {
            if (firstName == null) { throw new ArgumentNullException(nameof(firstName)); }

            var data = _mapper.Map<List<AuthorDto>>(await _authorReadRepository.GetAuthorsByFirstNameAsync(firstName, paginationFilter));
            var totalRecordCount = await _authorReadRepository.GetWhere(a => a.FirstName == firstName).CountAsync();

            return _paginationService.CreatePaginatedDataResult(HttpStatusCode.OK, data, totalRecordCount, paginationFilter, "");
        }

        /// <inheritdoc />
        public async Task<List<Author>> GetAuthorsByLastNameAsync(string lastName)
        {
            if (lastName == null) { throw new ArgumentNullException(nameof(lastName)); }

            return await _authorReadRepository.GetAuthorsByLastNameAsync(lastName);
        }

        /// <inheritdoc />
        public async Task<List<Author>> GetAuthorsByCountryOfBirthAsync(string country)
        {
            if (country == null) { throw new ArgumentNullException(nameof(country)); }

            return await _authorReadRepository.GetAuthorsByCountryOfBirthAsync(country);
        }

        /// <inheritdoc />
        public async Task<List<Author>> GetAuthorsByYearOfBirthAsync(int year)
        {
            if (year < 0) { throw new ArgumentOutOfRangeException(nameof(year)); }

            return await _authorReadRepository.GetAuthorsByYearOfBirthAsync(year);
        }

        /// <inheritdoc />
        public async Task<List<Author>> GetAuthorsAllowedReviewAsync()
        {
            return await _authorReadRepository.GetAuthorsAllowedReviewAsync();
        }

        /// <inheritdoc />
        public async Task<List<Author>> GetAuthorsNotAllowedReviewAsync()
        {
            return await _authorReadRepository.GetAuthorsNotAllowedReviewAsync();
        }

        /// <inheritdoc />
        public async Task<List<Author>> GetAuthorsAllowedRecommendationAsync()
        {
            return await _authorReadRepository.GetAuthorsAllowedRecommendationAsync();
        }

        /// <inheritdoc />
        public async Task<List<Author>> GetAuthorsNotAllowedRecommendationAsync()
        {
            return await _authorReadRepository.GetAuthorsNotAllowedRecommendationAsync();
        }

        /// <inheritdoc />
        public async Task<List<Author>> GetAuthorsAllowedSubscriptionAsync()
        {
            return await _authorReadRepository.GetAuthorsAllowedSubscriptionAsync();
        }

        /// <inheritdoc />
        public async Task<List<Author>> GetAuthorsNotAllowedSubscriptionAsync()
        {
            return await _authorReadRepository.GetAuthorsNotAllowedSubscriptionAsync();
        }

        /// <inheritdoc />
        public async Task<List<Author>> GetAuthorsByCreatorUserAsync(string userId)
        {
            if (userId == null) { throw new ArgumentNullException(nameof(userId)); }

            return await _authorReadRepository.GetAuthorsByCreatorUserAsync(userId);
        }

        /// <inheritdoc />
        public async Task<bool> CreateAuthorAsync(Author author)
        {
            if (author == null) { throw new ArgumentNullException(nameof(author)); }

            await _authorWriteRepository.AddAsync(author);
            int affectedCount = await _authorWriteRepository.SaveAsync();

            return affectedCount > 0;
        }

        /// <inheritdoc />
        public async Task<bool> UpdateAuthorAsync(Author author)
        {
            if (author == null) { throw new ArgumentNullException(nameof(author)); }

            _authorWriteRepository.Update(author);
            int affectedCount = await _authorWriteRepository.SaveAsync();

            return affectedCount > 0;
        }

        /// <inheritdoc />
        public async Task<bool> DeleteAuthorByIdAsync(string authorId)
        {
            if (authorId == null) { throw new ArgumentException(nameof(authorId)); }

            await _authorWriteRepository.RemoveAsync(authorId);
            int affectedCount = await _authorWriteRepository.SaveAsync();

            return affectedCount > 0;
        }
    }
}
