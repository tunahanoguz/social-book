using MediatR;
using SocialBook.Application.DTOs.Authors.Author;
using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorsByYearOfBirthQueryRequest : PaginationFilter, IRequest<PaginatedListDto<AuthorDto>>
    {
        /// <summary>
        /// The year of birth of the author
        /// </summary>
        /// <example>1812</example>
        public int YearOfBirth { get; set; }
    }
}
