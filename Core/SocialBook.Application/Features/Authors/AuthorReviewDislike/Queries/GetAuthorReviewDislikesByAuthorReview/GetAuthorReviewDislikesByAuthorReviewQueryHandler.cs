using AutoMapper;
using MediatR;
using SocialBook.Application.DTOs.Authors.AuthorReviewDislike;
using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;
using SocialBook.Application.Interfaces.Services.Authors;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorReviewDislikesByAuthorReviewQueryHandler : IRequestHandler<GetAuthorReviewDislikesByAuthorReviewQueryRequest, PaginatedListDto<AuthorReviewDislikeDto>>
    {
        private readonly IAuthorReviewDislikeService _authorReviewDislikeService;
        private readonly IMapper _mapper;

        public GetAuthorReviewDislikesByAuthorReviewQueryHandler(IAuthorReviewDislikeService authorReviewService, IMapper mapper)
        {
            _authorReviewDislikeService = authorReviewService;
            _mapper = mapper;
        }

        public async Task<PaginatedListDto<AuthorReviewDislikeDto>> Handle(GetAuthorReviewDislikesByAuthorReviewQueryRequest request, CancellationToken cancellationToken)
        {
            var paginationFilter = new PaginationFilter(request.PageNumber, request.PageSize);
            var data = await _authorReviewDislikeService.GetAuthorReviewDislikesByAuthorReviewAsync(request.AuthorReviewId, paginationFilter);

            return _mapper.Map<PaginatedListDto<AuthorReviewDislikeDto>>(data);
        }
    }
}
