using MediatR;

namespace SocialBook.Application.Features.Commands
{
    public class DeleteAuthorImageCommandRequest : IRequest<bool>
    {
        /// <summary>
        /// The identifier
        /// </summary>
        /// <example>6a899c34-e51e-443d-a315-959136f3e49b</example>
        public Guid Id { get; set; }
    }
}
