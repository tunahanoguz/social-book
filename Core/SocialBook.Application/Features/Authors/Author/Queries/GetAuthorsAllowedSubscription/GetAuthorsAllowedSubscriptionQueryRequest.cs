using MediatR;
using SocialBook.Application.Filters;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorsAllowedSubscriptionQueryRequest : PaginationFilter, IRequest<List<GetAuthorsAllowedSubscriptionQueryResponse>>
    {
    }
}
