using MediatR;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorsByCreatorUserQueryRequest : IRequest<List<GetAuthorsByCreatorUserQueryResponse>>
    {
        /// <summary>
        /// Gets or sets the creator user identifier
        /// </summary>
        public string CreatorUserId { get; set; }
    }
}
