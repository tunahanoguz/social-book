using MediatR;
using SocialBook.Application.DTOs.Authors.AuthorReviewImage;
using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorReviewImagesByAuthorReviewQueryRequest : PaginationFilter, IRequest<PaginatedListDto<AuthorReviewImageDto>>
    {
        /// <summary>
        /// The author review identifier
        /// </summary>
        /// <example>2823add5-60f3-4272-9ec1-087d69cca72c</example>
        public Guid AuthorReviewId { get; set; }
    }
}
