using FluentValidation;
using Library.Validators.RequestModels.Books;

namespace Library.Validators.Validators.Books
{
    public class UpdateBookRequestModelValidator : AbstractValidator<UpdateBookRequestModel>
    {
        public UpdateBookRequestModelValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0).WithMessage("Id must be greater than 0");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Title cannot be empty");
        }
    }
}
