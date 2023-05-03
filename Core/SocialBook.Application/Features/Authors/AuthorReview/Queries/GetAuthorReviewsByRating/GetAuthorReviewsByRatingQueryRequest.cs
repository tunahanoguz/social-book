using MediatR;
using SocialBook.Application.DTOs.Authors.AuthorReview;
using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorReviewsByRatingQueryRequest : PaginationFilter, IRequest<PaginatedListDto<AuthorReviewDto>>
    {
        /// <summary>
        /// The author rating (between 1-5 points)
        /// </summary>
        /// <example>5</example>
        public int Rating { get; set; }
    }
}
