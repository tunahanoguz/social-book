using MediatR;
using SocialBook.Application.DTOs.Authors.AuthorSubscription;
using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorSubscriptionsByAuthorQueryRequest : PaginationFilter, IRequest<PaginatedListDto<AuthorSubscriptionDto>>
    {
        /// <summary>
        /// The subscribed author identifier
        /// </summary>
        /// <example>2823add5-60f3-4272-9ec1-087d69cca72c</example>
        public Guid AuthorId { get; set; }
    }
}
