﻿using AutoMapper;
using MediatR;
using SocialBook.Application.Services.Authors;

namespace SocialBook.Application.Features
{
    public class GetAuthorByIdQueryHandler : IRequestHandler<GetAuthorByIdQueryRequest, GetAuthorByIdQueryResponse>
    {
        private readonly IAuthorService _authorService;
        private readonly IMapper _mapper;

        public GetAuthorByIdQueryHandler(IAuthorService authorService, IMapper mapper)
        {
            _authorService = authorService;
            _mapper = mapper;
        }

        public async Task<GetAuthorByIdQueryResponse> Handle(GetAuthorByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var author = await _authorService.GetAuthorById(request.AuthorId);
            return _mapper.Map<GetAuthorByIdQueryResponse>(author);
        }
    }
}
