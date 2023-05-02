using MediatR;
using SocialBook.Application.DTOs.Authors.AuthorRecommendation;
using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorRecommendationsByAuthorQueryRequest : PaginationFilter, IRequest<PaginatedListDto<AuthorRecommendationDto>>
    {
        /// <summary>
        /// The author identifier
        /// </summary>
        /// <example>022fb7f5-3528-4254-a9b4-b23fb3b2e85a</example>
        /// [FromRoute]
        public Guid AuthorId { get; set; }
    }
}
