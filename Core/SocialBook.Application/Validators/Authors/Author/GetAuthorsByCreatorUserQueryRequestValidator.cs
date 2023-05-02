using FluentValidation;
using SocialBook.Application.Features.Queries;
using SocialBook.Application.Validators.Common;

namespace SocialBook.Application.Validators.Authors.Author
{
    public class GetAuthorsByCreatorUserQueryRequestValidator : AbstractValidator<GetAuthorsByCreatorUserQueryRequest>
    {
        public GetAuthorsByCreatorUserQueryRequestValidator()
        {
            Include(new PaginationFilterValidator());

            RuleFor(x => x.CreatorUserId)
                .NotNull()
                .NotEmpty()
                .WithMessage("The creator user identifier cannot be null or empty!");

            RuleFor(x => x.CreatorUserId)
                .Must(IsValidGuid)
                .WithMessage("The creator user identifier must be a valid GUID!");
        }

        private bool IsValidGuid(string id)
        {
            Guid guid;
            return Guid.TryParse(id, out guid);
        }
    }
}
