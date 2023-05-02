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
        public Guid AuthorId { get; set; }
    }
}
