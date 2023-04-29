using AutoMapper;
using SocialBook.Application.Features.Queries;
using SocialBook.Application.Features.Commands;
using SocialBook.Domain.Entities.Authors;
using SocialBook.Application.DTOs.Authors.Author;

namespace SocialBook.Application.Mappings.Authors
{
    public class AuthorMapping : Profile
    {
        public AuthorMapping()
        {
            CreateMap<Author, GetAuthorByFirstNameQueryResponse>().ReverseMap();
            CreateMap<Author, GetAuthorsByFirstNameQueryResponse>().ReverseMap();
            CreateMap<Author, GetAuthorsByLastNameQueryResponse>().ReverseMap();
            CreateMap<Author, GetAuthorsByCountryOfBirthQueryResponse>().ReverseMap();
            CreateMap<Author, GetAuthorsByYearOfBirthQueryResponse>().ReverseMap();
            CreateMap<Author, GetAuthorsAllowedReviewQueryResponse>().ReverseMap();
            CreateMap<Author, GetAuthorsNotAllowedReviewQueryResponse>().ReverseMap();
            CreateMap<Author, GetAuthorsAllowedRecommendationQueryResponse>().ReverseMap();
            CreateMap<Author, GetAuthorsNotAllowedRecommendationQueryResponse>().ReverseMap();
            CreateMap<Author, GetAuthorsAllowedSubscriptionQueryResponse>().ReverseMap();
            CreateMap<Author, GetAuthorsNotAllowedSubscriptionQueryResponse>().ReverseMap();
            CreateMap<Author, GetAuthorsByCreatorUserQueryResponse>().ReverseMap();
            CreateMap<Author, CreateAuthorQueryRequest>().ReverseMap();
            CreateMap<Author, UpdateAuthorQueryRequest>().ReverseMap();

            CreateMap<Author, AuthorDto>().ReverseMap();
        }
    }
}
