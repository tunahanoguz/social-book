using MediatR;
using SocialBook.Application.DTOs.Authors.AuthorReview;

namespace SocialBook.Application.Features.Commands
{
    public class CreateAuthorReviewCommandRequest : IRequest<AuthorReviewDto>
    {
        /// <summary>
        /// The author rating (between 1-5 points)
        /// </summary>
        /// <example>5</example>
        public int Rating { get; set; }

        /// <summary>
        /// The comment about associated author
        /// </summary>
        /// <example>A great book.</example>
        public string Comment { get; set; }

        /// <summary>
        /// The author identifier
        /// </summary>
        /// <example>2823add5-60f3-4272-9ec1-087d69cca72c</example>
        public Guid AuthorId { get; set; }

        /// <summary>
        /// The user identifier
        /// </summary>
        /// <example>fbbfdce6-caa7-49ae-9118-13dc98d99600</example>
        public string UserId { get; set; }
    }
}
