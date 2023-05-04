using MediatR;
using SocialBook.Application.DTOs.Authors.AuthorReviewDislike;
using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorReviewDislikesByAuthorReviewQueryRequest : PaginationFilter, IRequest<PaginatedListDto<AuthorReviewDislikeDto>>
    {
        /// <summary>
        /// The author review identifier
        /// </summary>
        /// <example>19b469b0-1f15-463b-a13e-8a8797131f46</example>
        public Guid AuthorReviewId { get; set; }
    }
}
