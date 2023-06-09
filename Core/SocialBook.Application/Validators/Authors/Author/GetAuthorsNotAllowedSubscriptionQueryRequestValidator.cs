﻿using FluentValidation;
using SocialBook.Application.Features.Queries;
using SocialBook.Application.Validators.Common;

namespace SocialBook.Application.Validators.Authors.Author
{
    public class GetAuthorsNotAllowedSubscriptionQueryRequestValidator : AbstractValidator<GetAuthorsNotAllowedSubscriptionQueryRequest>
    {
        public GetAuthorsNotAllowedSubscriptionQueryRequestValidator()
        {
            Include(new PaginationFilterValidator());
        }
    }
}
