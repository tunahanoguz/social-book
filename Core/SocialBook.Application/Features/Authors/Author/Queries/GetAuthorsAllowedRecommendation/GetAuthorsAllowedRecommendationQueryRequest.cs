using MediatR;
using SocialBook.Application.DTOs.Authors.Author;
using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorsAllowedRecommendationQueryRequest : PaginationFilter, IRequest<PaginatedListDto<AuthorDto>>
    {
    }
}
