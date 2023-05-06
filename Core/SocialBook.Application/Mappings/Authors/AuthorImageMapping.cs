using AutoMapper;
using SocialBook.Application.DTOs.Authors.AuthorImage;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Mappings.Authors
{
    public class AuthorImageMapping : Profile
    {
        public AuthorImageMapping()
        {
            CreateMap<AuthorImage, AuthorImageDto>().ReverseMap();
        }
    }
}
