using MediatR;
using SocialBook.Application.DTOs.Authors.AuthorRecommendation;

namespace SocialBook.Application.Features.Commands
{
    public class CreateAuthorRecommendationCommandRequest : IRequest<AuthorRecommendationDto>
    {
        /// <summary>
        /// The recommended author identifier
        /// </summary>
        /// <example>2823add5-60f3-4272-9ec1-087d69cca72c</example>
        public Guid AuthorId { get; set; }

        /// <summary>
        /// The recommender user identifier
        /// </summary>
        /// <example>5088a487-2384-4eb6-ac10-eac5d24ee1d1</example>
        public string RecommenderUserId { get; set; }

        /// <summary>
        /// The recommendation recipient user identifier
        /// </summary>
        /// <example>92088e43-474e-4bd6-9dbe-cfc5293e885f</example>
        public string RecipientUserId { get; set; }
    }
}
