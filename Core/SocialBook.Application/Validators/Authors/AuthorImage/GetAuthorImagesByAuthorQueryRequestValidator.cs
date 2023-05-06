using FluentValidation;
using SocialBook.Application.Features.Queries;

namespace SocialBook.Application.Validators.Authors.AuthorImage
{
    public class GetAuthorImagesByAuthorQueryRequestValidator : AbstractValidator<GetAuthorImagesByAuthorQueryRequest>
    {
        public GetAuthorImagesByAuthorQueryRequestValidator()
        {
            RuleFor(x => x.AuthorId)
                .NotNull()
                .NotEmpty()
                .WithMessage("The author identifier cannot be null or empty!");

            RuleFor(x => x.AuthorId)
                .Must(authorId => IsValidGuid(authorId.ToString()))
                .WithMessage("The author identifier must be a valid GUID!");
        }

        private bool IsValidGuid(string id)
        {
            Guid guid;
            return Guid.TryParse(id, out guid);
        }
    }
}
