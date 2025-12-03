using FluentValidation;
using Library.Validators.RequestModels.Tags;

namespace Library.Validators.Validators.Tags
{
    public class UpdateTagRequestModelValidator : AbstractValidator<UpdateTagRequestModel>
    {
        public UpdateTagRequestModelValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0).WithMessage("Id must be greater than 0");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name cannot be empty");
        }
    }
}
