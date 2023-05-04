using MediatR;
using SocialBook.Application.DTOs.Authors.AuthorReviewLike;
using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorReviewLikesByAuthorReviewQueryRequest : PaginationFilter, IRequest<PaginatedListDto<AuthorReviewLikeDto>>
    {
        /// <summary>
        /// The author review identifier
        /// </summary>
        /// <example>19b469b0-1f15-463b-a13e-8a8797131f46</example>
        public Guid AuthorReviewId { get; set; }
    }
}
