using MediatR;
using SocialBook.Application.Filters;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorsByCountryOfBirthQueryRequest : PaginationFilter, IRequest<List<GetAuthorsByCountryOfBirthQueryResponse>>
    {
        /// <summary>
        /// The country of birth of the author
        /// </summary>
        /// <example>United Kingdom</example>
        public string CountryOfBirth { get; set; }
    }
}
