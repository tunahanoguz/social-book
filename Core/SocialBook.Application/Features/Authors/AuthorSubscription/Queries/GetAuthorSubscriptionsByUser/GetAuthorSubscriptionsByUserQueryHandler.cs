using AutoMapper;
using MediatR;
using SocialBook.Application.DTOs.Authors.AuthorSubscription;
using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;
using SocialBook.Application.Interfaces.Services.Authors;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorSubscriptionsByUserQueryHandler : IRequestHandler<GetAuthorSubscriptionsByUserQueryRequest, PaginatedListDto<AuthorSubscriptionDto>>
    {
        private readonly IAuthorSubscriptionService _authorSubscriptionService;
        private readonly IMapper _mapper;

        public GetAuthorSubscriptionsByUserQueryHandler(IAuthorSubscriptionService authorSubscriptionService, IMapper mapper)
        {
            _authorSubscriptionService = authorSubscriptionService;
            _mapper = mapper;
        }

        public async Task<PaginatedListDto<AuthorSubscriptionDto>> Handle(GetAuthorSubscriptionsByUserQueryRequest request, CancellationToken cancellationToken)
        {
            var paginationFilter = new PaginationFilter(request.PageNumber, request.PageSize);
            var data = await _authorSubscriptionService.GetAuthorSubscriptionsByUserAsync(request.UserId, paginationFilter);

            return _mapper.Map<PaginatedListDto<AuthorSubscriptionDto>>(data);
        }
    }
}
