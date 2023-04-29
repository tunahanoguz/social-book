using MediatR;
using SocialBook.Application.Filters;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorsNotAllowedSubscriptionQueryRequest : PaginationFilter, IRequest<List<GetAuthorsNotAllowedSubscriptionQueryResponse>>
    {
    }
}
