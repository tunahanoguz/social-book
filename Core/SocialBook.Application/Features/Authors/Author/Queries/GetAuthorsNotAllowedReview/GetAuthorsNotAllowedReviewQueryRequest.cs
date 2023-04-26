using MediatR;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorsNotAllowedReviewQueryRequest : IRequest<List<GetAuthorsNotAllowedReviewQueryResponse>>
    {
    }
}
