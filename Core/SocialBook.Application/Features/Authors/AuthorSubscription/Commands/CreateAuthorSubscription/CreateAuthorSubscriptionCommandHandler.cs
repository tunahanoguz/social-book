using AutoMapper;
using MediatR;
using SocialBook.Application.DTOs.Authors.AuthorSubscription;
using SocialBook.Application.Services.Authors;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Features.Commands
{
    public class CreateAuthorSubscriptionCommandHandler : IRequestHandler<CreateAuthorSubscriptionCommandRequest, AuthorSubscriptionDto>
    {
        private readonly IAuthorSubscriptionService _authorSubscriptionService;
        private readonly IMapper _mapper;

        public CreateAuthorSubscriptionCommandHandler(IAuthorSubscriptionService authorSubscriptionService, IMapper mapper)
        {
            _authorSubscriptionService = authorSubscriptionService;
            _mapper = mapper;
        }

        public async Task<AuthorSubscriptionDto> Handle(CreateAuthorSubscriptionCommandRequest request, CancellationToken cancellationToken)
        {
            var data = await _authorSubscriptionService.CreateAuthorSubscriptionAsync(_mapper.Map<AuthorSubscription>(request));

            return _mapper.Map<AuthorSubscriptionDto>(data);
        }
    }
}
