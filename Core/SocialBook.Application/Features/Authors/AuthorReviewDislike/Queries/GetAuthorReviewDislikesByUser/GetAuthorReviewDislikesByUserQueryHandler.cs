using AutoMapper;
using MediatR;
using SocialBook.Application.DTOs.Authors.AuthorReviewDislike;
using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;
using SocialBook.Application.Services.Authors;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorReviewDislikesByUserQueryHandler : IRequestHandler<GetAuthorReviewDislikesByUserQueryRequest, PaginatedListDto<AuthorReviewDislikeDto>>
    {
        private readonly IAuthorReviewDislikeService _authorReviewDislikeService;
        private readonly IMapper _mapper;

        public GetAuthorReviewDislikesByUserQueryHandler(IAuthorReviewDislikeService authorReviewService, IMapper mapper)
        {
            _authorReviewDislikeService = authorReviewService;
            _mapper = mapper;
        }

        public async Task<PaginatedListDto<AuthorReviewDislikeDto>> Handle(GetAuthorReviewDislikesByUserQueryRequest request, CancellationToken cancellationToken)
        {
            var paginationFilter = new PaginationFilter(request.PageNumber, request.PageSize);
            var data = await _authorReviewDislikeService.GetAuthorReviewDislikesByAuthorReviewAsync(request.UserId, paginationFilter);

            return _mapper.Map<PaginatedListDto<AuthorReviewDislikeDto>>(data);
        }
    }
}
