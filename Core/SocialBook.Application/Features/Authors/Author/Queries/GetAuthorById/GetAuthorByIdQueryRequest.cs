using MediatR;
using SocialBook.Application.DTOs.Authors.Author;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorByIdQueryRequest : IRequest<AuthorDto>
    {
        /// <summary>
        /// The author identifier
        /// </summary>
        /// <example>2823add5-60f3-4272-9ec1-087d69cca72c</example>
        public string Id { get; set; }
    }
}
