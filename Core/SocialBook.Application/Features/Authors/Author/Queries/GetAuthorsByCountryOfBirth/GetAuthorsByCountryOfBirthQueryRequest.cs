using MediatR;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorsByCountryOfBirthQueryRequest : IRequest<List<GetAuthorsByCountryOfBirthQueryResponse>>
    {
        /// <summary>
        /// Gets or sets the country of birth of the author
        /// </summary>
        public string CountryOfBirth { get; set; }
    }
}
