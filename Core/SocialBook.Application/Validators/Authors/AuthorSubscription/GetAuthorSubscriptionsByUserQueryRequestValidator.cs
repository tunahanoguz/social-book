using FluentValidation;
using SocialBook.Application.Features.Queries;

namespace SocialBook.Application.Validators.Authors.AuthorSubscription
{
    public class GetAuthorSubscriptionsByUserQueryRequestValidator : AbstractValidator<GetAuthorSubscriptionsByUserQueryRequest>
    {
        public GetAuthorSubscriptionsByUserQueryRequestValidator()
        {
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
