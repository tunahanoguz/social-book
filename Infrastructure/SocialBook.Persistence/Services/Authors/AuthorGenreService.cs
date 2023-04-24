using SocialBook.Application.Repositories.Authors;
using SocialBook.Application.Services.Authors;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Persistence.Services.Authors
{
    public class AuthorGenreService : IAuthorGenreService
    {
        private readonly IAuthorGenreReadRepository _authorGenreReadRepository;
        private readonly IAuthorGenreWriteRepository _authorGenreWriteRepository;

        public AuthorGenreService(IAuthorGenreReadRepository authorGenreReadRepository, IAuthorGenreWriteRepository authorGenreWriteRepository)
        {
            _authorGenreReadRepository = authorGenreReadRepository;
            _authorGenreWriteRepository = authorGenreWriteRepository;
        }

        public async Task<bool> CreateAuthorGenreAsync(AuthorGenre authorGenre)
        {
            if (authorGenre == null) { throw new ArgumentNullException(nameof(authorGenre)); }

            return await _authorGenreWriteRepository.AddAsync(authorGenre);
        }

        public bool UpdateAuthorGenre(AuthorGenre authorGenre)
        {
            if (authorGenre == null) { throw new ArgumentNullException(nameof(authorGenre)); }

            return _authorGenreWriteRepository.Update(authorGenre);
        }

        public bool DeleteAuthorGenre(AuthorGenre authorGenre)
        {
            if (authorGenre == null) { throw new ArgumentNullException(nameof(authorGenre)); }

            return _authorGenreWriteRepository.Remove(authorGenre);
        }
    }
}
