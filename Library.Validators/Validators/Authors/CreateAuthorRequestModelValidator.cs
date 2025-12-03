using FluentValidation;
using Library.Validators.RequestModels.Authors;

namespace Library.Validators.Validators.Authors
{
    public class CreateAuthorRequestModelValidator : AbstractValidator<CreateAuthorRequestModel>
    {
        public CreateAuthorRequestModelValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("FirstName cannot be empty");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("LastName cannot be empty");
        }
    }
}
