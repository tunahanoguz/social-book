using MediatR;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorsNotAllowedRecommendationQueryRequest : IRequest<List<GetAuthorsNotAllowedRecommendationQueryResponse>>
    {
    }
}
