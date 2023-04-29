﻿using MediatR;
using SocialBook.Application.Filters;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorsByYearOfBirthQueryRequest : PaginationFilter, IRequest<List<GetAuthorsByYearOfBirthQueryResponse>>
    {
        /// <summary>
        /// The year of birth of the author
        /// </summary>
        /// <example>1812</example>
        public int YearOfBirth { get; set; }
    }
}
