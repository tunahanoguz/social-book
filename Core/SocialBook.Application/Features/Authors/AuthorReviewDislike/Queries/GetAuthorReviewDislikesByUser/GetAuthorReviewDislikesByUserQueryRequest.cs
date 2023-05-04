using MediatR;
using SocialBook.Application.DTOs.Authors.AuthorReviewDislike;
using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorReviewDislikesByUserQueryRequest : PaginationFilter, IRequest<PaginatedListDto<AuthorReviewDislikeDto>>
    {
        /// <summary>
        /// The user identifier
        /// </summary>
        /// <example>19b469b0-1f15-463b-a13e-8a8797131f46</example>
        public string UserId { get; set; }
    }
}
