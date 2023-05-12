using MediatR;
using SocialBook.Application.DTOs.Authors.Author;

namespace SocialBook.Application.Features.Commands
{
    public class DeleteAuthorCommandRequest : IRequest<AuthorDto>
    {
        /// <summary>
        /// The identifier
        /// </summary>
        /// <example>a1cf5611-cf6a-4c46-99cf-4fe34c71a893</example>
        public string Id { get; set; }
    }
}
