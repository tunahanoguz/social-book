using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Services.Authors
{
    public interface IAuthorGenreService
    {
        Task<bool> CreateAuthorGenreAsync(AuthorGenre authorGenre);
        bool UpdateAuthorGenre(AuthorGenre authorGenre);
        bool DeleteAuthorGenre(AuthorGenre authorGenre);
    }
}
