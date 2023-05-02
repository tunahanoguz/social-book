using MediatR;

namespace SocialBook.Application.Features.Commands
{
    public class DeleteAuthorGenreCommandRequest : IRequest<bool>
    {
        /// <summary>
        /// The identifier
        /// </summary>
        /// <example>08c6b198-c710-42b6-b237-9c3ed087bd3c</example>
        public string Id { get; set; }
    }
}
