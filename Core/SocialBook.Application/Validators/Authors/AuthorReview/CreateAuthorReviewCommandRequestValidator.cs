using FluentValidation;
using SocialBook.Application.Features.Commands;

namespace SocialBook.Application.Validators.Authors.AuthorReview
{
    public class CreateAuthorReviewCommandRequestValidator : AbstractValidator<CreateAuthorReviewCommandRequest>
    {
        public CreateAuthorReviewCommandRequestValidator()
        {
            RuleFor(x => x.Rating)
                .NotNull()
                .NotEmpty()
                .WithMessage("The rating cannot be null or empty!");

            RuleFor(x => x.Rating)
                .GreaterThan(0)
                .WithMessage("The rating must be grater than zero!");

            RuleFor(x => x.Comment)
                .NotNull()
                .NotEmpty()
                .WithMessage("The comment cannot be null or empty!");

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
                .WithMessage("The user identifier cannot be null or empty!");

            RuleFor(x => x.UserId)
                .Must(IsValidGuid)
                .WithMessage("The user identifier must be a valid GUID!");
        }

        private bool IsValidGuid(string id)
        {
            Guid guid;
            return Guid.TryParse(id, out guid);
        }
    }
}
