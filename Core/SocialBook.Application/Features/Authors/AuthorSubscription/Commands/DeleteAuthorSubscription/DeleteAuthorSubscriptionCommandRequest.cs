using MediatR;

namespace SocialBook.Application.Features.Commands
{
    public class DeleteAuthorSubscriptionCommandRequest : IRequest<bool>
    {
        /// <summary>
        /// The identifier
        /// </summary>
        /// <example>6dafbff6-ebb1-483a-8461-8ab6e2ec78d3</example>
        public Guid Id { get; set; }
    }
}
