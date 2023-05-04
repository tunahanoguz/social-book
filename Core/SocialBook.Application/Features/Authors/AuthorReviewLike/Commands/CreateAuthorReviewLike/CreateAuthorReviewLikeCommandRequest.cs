using MediatR;
using SocialBook.Application.DTOs.Authors.AuthorReviewLike;

namespace SocialBook.Application.Features.Commands
{
    public class CreateAuthorReviewLikeCommandRequest : IRequest<AuthorReviewLikeDto>
    {
        /// <summary>
        /// The author review identifier
        /// </summary>
        /// <example>19b469b0-1f15-463b-a13e-8a8797131f46</example>
        public Guid AuthorReviewId { get; set; }

        /// <summary>
        /// The identifier of the user who liked the author review
        /// </summary>
        /// <example>92088e43-474e-4bd6-9dbe-cfc5293e885f</example>
        public string UserId { get; set; }
    }
}
