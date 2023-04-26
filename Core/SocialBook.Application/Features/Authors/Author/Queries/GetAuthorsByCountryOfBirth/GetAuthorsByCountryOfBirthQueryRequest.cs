using MediatR;

namespace SocialBook.Application.Features.Authors
{
    public class GetAuthorsByCountryOfBirthQueryRequest : IRequest<List<GetAuthorsByCountryOfBirthQueryResponse>>
    {
        /// <summary>
        /// Gets or sets the first name
        /// </summary>
        public string CountryOfBirth { get; set; }
    }
}
