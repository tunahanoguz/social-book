using MediatR;
using SocialBook.Application.Filters;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorsNotAllowedRecommendationQueryRequest : PaginationFilter, IRequest<List<GetAuthorsNotAllowedRecommendationQueryResponse>>
    {
    }
}
