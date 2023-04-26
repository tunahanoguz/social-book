using MediatR;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorsAllowedSubscriptionQueryRequest : IRequest<List<GetAuthorsAllowedSubscriptionQueryResponse>>
    {
    }
}
