using MediatR;

namespace SocialBook.Application.Features.Authors
{
    public class GetAuthorsByCountryOfBirthQueryRequest : IRequest<List<GetAuthorsByCountryOfBirthQueryResponse>>
    {
        /// <summary>
        /// Gets or sets the country of birth of the author
        /// </summary>
        public string CountryOfBirth { get; set; }
    }
}
