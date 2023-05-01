using MediatR;
using Microsoft.AspNetCore.Mvc;
using SocialBook.Application.DTOs.Authors.Author;
using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorsByFirstNameQueryRequest : PaginationFilter, IRequest<PaginatedListDto<AuthorDto>>
    {
        /// <summary>
        /// The first name
        /// </summary>
        /// <example>Charles</example>
        [FromRoute]
        public string FirstName { get; set; }
    }
}
