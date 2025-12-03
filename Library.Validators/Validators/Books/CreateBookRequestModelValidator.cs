using FluentValidation;
using Library.Validators.RequestModels.Books;

namespace Library.Validators.Validators.Books
{
    public class CreateBookRequestModelValidator : AbstractValidator<CreateBookRequestModel>
    {
        public CreateBookRequestModelValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Title cannot be empty");
        }
    }
}
