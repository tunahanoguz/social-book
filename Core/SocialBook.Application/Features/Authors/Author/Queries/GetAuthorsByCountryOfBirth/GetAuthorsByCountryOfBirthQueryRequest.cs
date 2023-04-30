using MediatR;
using SocialBook.Application.DTOs.Authors.Author;
using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorsByCountryOfBirthQueryRequest : PaginationFilter, IRequest<PaginatedListDto<AuthorDto>>
    {
        /// <summary>
        /// The country of birth of the author
        /// </summary>
        /// <example>United Kingdom</example>
        public string CountryOfBirth { get; set; }
    }
}
