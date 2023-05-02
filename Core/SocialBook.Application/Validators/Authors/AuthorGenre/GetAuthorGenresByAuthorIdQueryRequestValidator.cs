using FluentValidation;
using SocialBook.Application.Features.Queries;
using SocialBook.Application.Validators.Common;

namespace SocialBook.Application.Validators.Authors.AuthorGenre
{
    public class GetAuthorGenresByAuthorIdQueryRequestValidator : AbstractValidator<GetAuthorGenresByAuthorIdQueryRequest>
    {
        public GetAuthorGenresByAuthorIdQueryRequestValidator()
        {
            Include(new PaginationFilterValidator());

            RuleFor(x => x.AuthorId)
                .NotNull()
                .NotEmpty()
                .WithMessage("The author identifier cannot be null or empty!");

            RuleFor(x => x.AuthorId)
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
