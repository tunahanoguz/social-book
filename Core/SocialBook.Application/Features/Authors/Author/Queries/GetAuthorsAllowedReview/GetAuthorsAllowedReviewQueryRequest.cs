using MediatR;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorsAllowedReviewQueryRequest : IRequest<List<GetAuthorsAllowedReviewQueryResponse>>
    {
    }
}
