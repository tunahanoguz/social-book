using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;
using SocialBook.Application.Repositories.Authors;
using SocialBook.Application.Services.Authors;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Persistence.Services.Authors
{
    public class AuthorGenreService : IAuthorGenreService
    {
        private readonly IAuthorGenreReadRepository _authorGenreReadRepository;
        private readonly IAuthorGenreWriteRepository _authorGenreWriteRepository;

        public AuthorGenreService(IAuthorGenreReadRepository authorGenreReadRepository,
            IAuthorGenreWriteRepository authorGenreWriteRepository)
        {
            _authorGenreReadRepository = authorGenreReadRepository;
            _authorGenreWriteRepository = authorGenreWriteRepository;
        }

        /// <inheritdoc />
        public Task<PaginatedListDto<AuthorGenre>> GetAuthorGenresByAuthorId(string authorId, PaginationFilter paginationFilter)
        {
            if (authorId == null) { throw new ArgumentNullException(nameof(authorId)); };

            return _authorGenreReadRepository.GetWhere(x => x.AuthorId == Guid.Parse(authorId), paginationFilter);
        }

        /// <inheritdoc />
        public async Task<AuthorGenre> CreateAuthorGenreAsync(AuthorGenre authorGenre)
        {
            if (authorGenre == null) { throw new ArgumentNullException(nameof(authorGenre)); }

            await _authorGenreWriteRepository.AddAsync(authorGenre);
            await _authorGenreWriteRepository.SaveAsync();

            return await _authorGenreReadRepository.GetByIdAsync(authorGenre.Id.ToString(), false);
        }

        /// <inheritdoc />
        public async Task<bool> DeleteAuthorGenreAsync(string authorGenreId)
        {
            if (authorGenreId == null) { throw new ArgumentNullException(nameof(authorGenreId)); }

            await _authorGenreWriteRepository.RemoveAsync(authorGenreId);
            int affectedCount = await _authorGenreWriteRepository.SaveAsync();

            return affectedCount > 0;
        }
    }
}
