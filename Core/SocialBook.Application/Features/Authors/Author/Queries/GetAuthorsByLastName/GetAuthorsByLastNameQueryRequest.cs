﻿using MediatR;

namespace SocialBook.Application.Features.Authors
{
    public class GetAuthorsByLastNameQueryRequest : IRequest<List<GetAuthorsByLastNameQueryResponse>>
    {
        /// <summary>
        /// Gets or sets the last name
        /// </summary>
        public string LastName { get; set; }
    }
}
