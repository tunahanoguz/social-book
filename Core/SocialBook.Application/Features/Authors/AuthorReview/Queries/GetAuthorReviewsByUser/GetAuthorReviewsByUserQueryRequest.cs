using MediatR;
using SocialBook.Application.DTOs.Authors.AuthorReview;
using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorReviewsByUserQueryRequest : PaginationFilter, IRequest<PaginatedListDto<AuthorReviewDto>>
    {
        /// <summary>
        /// The user identifier
        /// </summary>
        /// <example>fbbfdce6-caa7-49ae-9118-13dc98d99600</example>
        public string UserId { get; set; }
    }
}
