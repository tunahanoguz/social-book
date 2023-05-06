using FluentValidation;
using SocialBook.Application.Features.Commands;

namespace SocialBook.Application.Validators.Authors.AuthorReviewImage
{
    public class DeleteAuthorReviewImageCommandRequestValidator : AbstractValidator<DeleteAuthorReviewImageCommandRequest>
    {
        public DeleteAuthorReviewImageCommandRequestValidator()
        {
            RuleFor(x => x.Id)
                .NotNull()
                .NotEmpty()
                .WithMessage("The author review image identifier cannot be null or empty!");

            RuleFor(x => x.Id)
                .Must(id => IsValidGuid(id.ToString()))
                .WithMessage("The author review image identifier must be a valid GUID!");
        }

        private bool IsValidGuid(string id)
        {
            Guid guid;
            return Guid.TryParse(id, out guid);
        }
    }
}
