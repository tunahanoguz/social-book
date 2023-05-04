using MediatR;
using SocialBook.Application.DTOs.Authors.AuthorReviewLike;

namespace SocialBook.Application.Features.Commands
{
    public class CreateAuthorReviewLikeCommandRequest : IRequest<AuthorReviewLikeDto>
    {
        /// <summary>
        /// The author review identifier
        /// </summary>
        public Guid AuthorReviewId { get; set; }

        /// <summary>
        /// The identifier of the user who liked the author review
        /// </summary>
        public string UserId { get; set; }
    }
}
