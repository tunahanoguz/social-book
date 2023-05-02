using MediatR;
using SocialBook.Application.DTOs.Authors.AuthorGenre;
using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorGenresByAuthorIdQueryRequest : PaginationFilter, IRequest<PaginatedListDto<AuthorGenreDto>>
    {
        /// <summary>
        /// The author identifier
        /// </summary>
        /// <example>022fb7f5-3528-4254-a9b4-b23fb3b2e85a</example>
        /// [FromRoute]
        public string AuthorId { get; set; }
    }
}
