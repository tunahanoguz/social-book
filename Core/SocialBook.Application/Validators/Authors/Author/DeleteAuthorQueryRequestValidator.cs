using FluentValidation;
using SocialBook.Application.Features.Commands;

namespace SocialBook.Application.Validators.Authors.Author
{
    public class DeleteAuthorQueryRequestValidator : AbstractValidator<DeleteAuthorQueryRequest>
    {
        public DeleteAuthorQueryRequestValidator()
        {
            RuleFor(x => x.Id)
                .NotNull()
                .NotEmpty()
                .WithMessage("The identifier cannot be null or empty!");

            RuleFor(x => x.Id)
                .Must(IsValidGuid)
                .WithMessage("The identifier must be a valid GUID!");
        }

        private bool IsValidGuid(string id)
        {
            Guid guid;
            return Guid.TryParse(id, out guid);
        }
    }
}
