using FluentValidation;
using SocialBook.Application.Features.Commands;

namespace SocialBook.Application.Validators.Authors
{
    public class UpdateAuthorQueryRequestValidator : AbstractValidator<UpdateAuthorQueryRequest>
    {
        public UpdateAuthorQueryRequestValidator()
        {
            RuleFor(x => x.Id)
                .NotNull()
                .NotEmpty()
                .WithMessage("The identifier cannot be null or empty!");

            RuleFor(x => x.Id)
                .Must(IsValidGuid)
                .WithMessage("The identifier must be a valid GUID!");

            RuleFor(x => x.FirstName)
                .NotNull()
                .NotEmpty()
                .WithMessage("The first name cannot be null or empty!");

            RuleFor(x => x.FirstName)
                .MinimumLength(2)
                .WithMessage("The length of first name must be greater one!");

            RuleFor(x => x.LastName)
                .NotNull()
                .NotEmpty()
                .WithMessage("The last name cannot be null or empty!");

            RuleFor(x => x.LastName)
                .MinimumLength(2)
                .WithMessage("The length of last name must be greater one!");

            RuleFor(x => x.Description)
                .NotNull()
                .NotEmpty()
                .WithMessage("The description cannot be null or empty!");

            RuleFor(x => x.CountryOfBirth)
                .NotNull()
                .NotEmpty()
                .WithMessage("The country of birth cannot be null or empty!");

            RuleFor(x => x.DateOfBirth)
                .NotNull()
                .NotEmpty()
                .WithMessage("The date of birth cannot be null or empty!");

            RuleFor(x => x.MetaTitle)
                .NotNull()
                .NotEmpty()
                .WithMessage("The meta title cannot be null or empty!");

            RuleFor(x => x.MetaDescription)
                .NotNull()
                .NotEmpty()
                .WithMessage("The meta description cannot be null or empty!");

            RuleFor(x => x.MetaKeywords)
                .NotNull()
                .NotEmpty()
                .WithMessage("The meta keywords cannot be null or empty!");

            RuleFor(x => x.Slug)
                .NotNull()
                .NotEmpty()
                .WithMessage("The slug cannot be null or empty!");

            RuleFor(x => x.IsAllowedReview)
                .NotNull()
                .NotEmpty()
                .WithMessage("The is-allowed-review cannot be null or empty!");

            RuleFor(x => x.IsAllowedRecommendation)
                .NotNull()
                .NotEmpty()
                .WithMessage("The is-allowed-recommendation cannot be null or empty!");

            RuleFor(x => x.IsAllowedSubscription)
                .NotNull()
                .NotEmpty()
                .WithMessage("The is-allowed-subscription cannot be null or empty!");

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
