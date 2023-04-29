﻿using MediatR;
using SocialBook.Application.Filters;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorsByCreatorUserQueryRequest : PaginationFilter, IRequest<List<GetAuthorsByCreatorUserQueryResponse>>
    {
        /// <summary>
        /// The creator user identifier
        /// </summary>
        /// <example>92088e43-474e-4bd6-9dbe-cfc5293e885f</example>
        public string CreatorUserId { get; set; }
    }
}
