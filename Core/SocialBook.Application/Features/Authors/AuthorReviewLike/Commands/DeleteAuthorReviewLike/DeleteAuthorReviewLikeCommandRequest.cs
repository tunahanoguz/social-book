using MediatR;

namespace SocialBook.Application.Features.Commands
{
    public class DeleteAuthorReviewLikeCommandRequest : IRequest<bool>
    {
        /// <summary>
        /// The identifier
        /// </summary>
        /// <example>19b469b0-1f15-463b-a13e-8a8797131f46</example>
        public Guid Id { get; set; }
    }
}
