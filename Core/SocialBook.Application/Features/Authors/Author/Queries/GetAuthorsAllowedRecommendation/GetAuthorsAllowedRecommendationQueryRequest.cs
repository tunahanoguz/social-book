using MediatR;
using SocialBook.Application.Filters;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorsAllowedRecommendationQueryRequest : PaginationFilter, IRequest<List<GetAuthorsAllowedRecommendationQueryResponse>>
    {
    }
}
