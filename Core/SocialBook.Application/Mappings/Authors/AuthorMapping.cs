using AutoMapper;
using SocialBook.Application.Features;
using SocialBook.Application.Features.Authors;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Mappings.Authors
{
    public class AuthorMapping : Profile
    {
        public AuthorMapping()
        {
            CreateMap<Author, GetAuthorByIdQueryResponse>().ReverseMap();
            CreateMap<Author, GetAuthorsByFirstNameQueryResponse>().ReverseMap();
            CreateMap<Author, GetAuthorsByLastNameQueryResponse>().ReverseMap();
            CreateMap<Author, GetAuthorsByCountryOfBirthQueryResponse>().ReverseMap();
            CreateMap<Author, GetAuthorsByYearOfBirthQueryResponse>().ReverseMap();
            CreateMap<Author, GetAuthorsAllowedReviewQueryResponse>().ReverseMap();
            CreateMap<Author, GetAuthorsNotAllowedReviewQueryResponse>().ReverseMap();
        }
    }
}
