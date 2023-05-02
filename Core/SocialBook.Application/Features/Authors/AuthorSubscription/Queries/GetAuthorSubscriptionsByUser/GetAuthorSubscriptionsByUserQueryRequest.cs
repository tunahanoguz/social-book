using MediatR;
using SocialBook.Application.DTOs.Authors.AuthorSubscription;
using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorSubscriptionsByUserQueryRequest : PaginationFilter, IRequest<PaginatedListDto<AuthorSubscriptionDto>>
    {
        /// <summary>
        /// The identifier of the user who subscribed to the author
        /// </summary>
        public string UserId { get; set; }
    }
}
