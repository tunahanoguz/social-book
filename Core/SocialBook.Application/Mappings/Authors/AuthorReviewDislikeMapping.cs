using AutoMapper;
using SocialBook.Application.DTOs.Authors.AuthorReviewDislike;
using SocialBook.Application.Features.Commands;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Mappings.Authors
{
    public class AuthorReviewDislikeMapping : Profile
    {
        public AuthorReviewDislikeMapping()
        {
            CreateMap<AuthorReviewDislike, AuthorReviewDislikeDto>().ReverseMap();
            CreateMap<AuthorReviewDislike, CreateAuthorReviewDislikeCommandRequest>().ReverseMap();
        }
    }
}
