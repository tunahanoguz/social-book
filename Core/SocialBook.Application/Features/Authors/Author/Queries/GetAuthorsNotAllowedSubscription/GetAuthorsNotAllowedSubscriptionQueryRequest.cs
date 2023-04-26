using MediatR;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorsNotAllowedSubscriptionQueryRequest : IRequest<List<GetAuthorsNotAllowedSubscriptionQueryResponse>>
    {
    }
}
