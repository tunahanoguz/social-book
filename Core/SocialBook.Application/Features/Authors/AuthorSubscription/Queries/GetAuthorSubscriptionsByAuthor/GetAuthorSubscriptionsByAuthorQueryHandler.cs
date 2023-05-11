using AutoMapper;
using MediatR;
using SocialBook.Application.DTOs.Authors.AuthorSubscription;
using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;
using SocialBook.Application.Interfaces.Services.Authors;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorSubscriptionsByAuthorQueryHandler : IRequestHandler<GetAuthorSubscriptionsByAuthorQueryRequest, PaginatedListDto<AuthorSubscriptionDto>>
    {
        private readonly IAuthorSubscriptionService _authorSubscriptionService;
        private readonly IMapper _mapper;

        public GetAuthorSubscriptionsByAuthorQueryHandler(IAuthorSubscriptionService authorSubscriptionService, IMapper mapper)
        {
            _authorSubscriptionService = authorSubscriptionService;
            _mapper = mapper;
        }

        public async Task<PaginatedListDto<AuthorSubscriptionDto>> Handle(GetAuthorSubscriptionsByAuthorQueryRequest request, CancellationToken cancellationToken)
        {
            var paginationFilter = new PaginationFilter(request.PageNumber, request.PageSize);
            var data = await _authorSubscriptionService.GetAuthorSubscriptionsByAuthorAsync(request.AuthorId, paginationFilter);

            return _mapper.Map<PaginatedListDto<AuthorSubscriptionDto>>(data);
        }
    }
}
