using MediatR;
using SocialBook.Application.DTOs.Authors.AuthorGenre;

namespace SocialBook.Application.Features.Commands
{
    public class CreateAuthorGenreCommandRequest : IRequest<AuthorGenreDto>
    {
        /// <summary>
        /// The author identifier
        /// </summary>
        /// <example>6729df32-c197-4b42-8b58-d88e1c202346</example>
        public string AuthorId { get; set; }

        /// <summary>
        /// The genre identifier
        /// </summary>
        /// <example>c0385818-0ea3-4e64-aede-00a6ac1d4f7a</example>
        public string GenreId { get; set; }
    }
}
