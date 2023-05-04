using MediatR;
using SocialBook.Application.DTOs.Authors.AuthorReviewLike;
using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;

namespace SocialBook.Application.Features.Authors.AuthorReviewLike.Queries.GetAuthorReviewLikesByUser
{
    public class GetAuthorReviewLikesByUserQueryRequest : PaginationFilter, IRequest<PaginatedListDto<AuthorReviewLikeDto>>
    {
        /// <summary>
        /// The user identifier
        /// </summary>
        /// <example>19b469b0-1f15-463b-a13e-8a8797131f46</example>
        public string UserId { get; set; }
    }
}
