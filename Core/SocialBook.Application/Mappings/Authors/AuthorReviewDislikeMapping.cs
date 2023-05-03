using AutoMapper;
using SocialBook.Application.DTOs.Authors.AuthorReviewDislike;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Mappings.Authors
{
    public class AuthorReviewDislikeMapping : Profile
    {
        public AuthorReviewDislikeMapping()
        {
            CreateMap<AuthorReviewDislike, AuthorReviewDislikeDto>().ReverseMap();
        }
    }
}
