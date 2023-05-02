using FluentValidation;
using SocialBook.Application.Features.Commands;

namespace SocialBook.Application.Validators.Authors.AuthorSubscription
{
    public class CreateAuthorSubscriptionCommandRequestValidator : AbstractValidator<CreateAuthorSubscriptionCommandRequest>
    {
        public CreateAuthorSubscriptionCommandRequestValidator()
        {
            RuleFor(x => x.AuthorId)
                .NotNull()
                .NotEmpty()
                .WithMessage("The author identifier cannot be null or empty!");

            RuleFor(x => x.AuthorId)
                .Must(authorId => IsValidGuid(authorId.ToString()))
                .WithMessage("The author identifier must be a valid GUID!");

            RuleFor(x => x.UserId)
                .NotNull()
                .NotEmpty()
                .WithMessage("The author identifier cannot be null or empty!");

            RuleFor(x => x.UserId)
                .Must(IsValidGuid)
                .WithMessage("The author identifier must be a valid GUID!");
        }

        private bool IsValidGuid(string id)
        {
            Guid guid;
            return Guid.TryParse(id, out guid);
        }
    }
}
