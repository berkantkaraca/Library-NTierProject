using FluentValidation;
using Library.Validators.RequestModels.Tags;

namespace Library.Validators.Validators.Tags
{
    public class CreateTagRequestModelValidator : AbstractValidator<CreateTagRequestModel>
    {
        public CreateTagRequestModelValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name cannot be empty");
        }
    }
}
