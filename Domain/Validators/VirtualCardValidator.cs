using api_test.Domain.Entities;
using FluentValidation;

namespace api_test.Domain.Validators
{
    public class VirtualCardAddValidator : AbstractValidator<VirtualCard>
    {
        public VirtualCardAddValidator()
        {
            RuleFor(entity => entity.Id).NotEmpty().WithMessage("Campo obrigatório!");
            RuleFor(entity => entity.Id).NotNull().WithMessage("Campo obrigatório!");
        }
    }

    public class VirtualCardUpdateValidator : AbstractValidator<VirtualCard>
    {
        public VirtualCardUpdateValidator()
        {
            RuleFor(entity => entity.Id).NotEmpty().WithMessage("Campo obrigatório!");
            RuleFor(entity => entity.Id).NotNull().WithMessage("Campo obrigatório!");
        }
    }

    public class VirtualCardRemoveValidator : AbstractValidator<VirtualCard>
    {
        public VirtualCardRemoveValidator()
        {
            RuleFor(entity => entity.Id).NotEmpty().WithMessage("Campo obrigatório!");
            RuleFor(entity => entity.Excluded).Equal(false).WithMessage("Registro já excluído!");
        }
    }


}
