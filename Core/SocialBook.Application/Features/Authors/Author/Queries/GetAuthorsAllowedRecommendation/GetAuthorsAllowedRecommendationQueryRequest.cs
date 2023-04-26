using MediatR;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorsAllowedRecommendationQueryRequest : IRequest<List<GetAuthorsAllowedRecommendationQueryResponse>>
    {
    }
}
