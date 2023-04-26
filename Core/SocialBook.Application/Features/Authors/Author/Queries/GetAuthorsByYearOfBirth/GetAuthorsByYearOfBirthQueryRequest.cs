using MediatR;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorsByYearOfBirthQueryRequest : IRequest<List<GetAuthorsByYearOfBirthQueryResponse>>
    {
        /// <summary>
        /// Gets or sets the year of birth of the author
        /// </summary>
        public int YearOfBirth { get; set; }
    }
}
