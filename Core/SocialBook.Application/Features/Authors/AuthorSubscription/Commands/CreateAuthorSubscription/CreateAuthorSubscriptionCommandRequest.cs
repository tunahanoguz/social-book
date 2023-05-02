using MediatR;
using SocialBook.Application.DTOs.Authors.AuthorSubscription;

namespace SocialBook.Application.Features.Commands
{
    public class CreateAuthorSubscriptionCommandRequest : IRequest<AuthorSubscriptionDto>
    {
        /// <summary>
        /// The subscribed author identifier
        /// </summary>
        /// <example>2823add5-60f3-4272-9ec1-087d69cca72c</example>
        public Guid AuthorId { get; set; }

        /// <summary>
        /// The identifier of the user who subscribed to the author
        /// </summary>
        /// <example>5088a487-2384-4eb6-ac10-eac5d24ee1d1</example>
        public string UserId { get; set; }
    }
}
