using FluentValidation;

namespace Permisos.Application.Permisos.Commands.CreatePermiso
{
    public class CreatePermisoCommandValidator : AbstractValidator<CreatePermisoCommand>
    {
        public CreatePermisoCommandValidator()
        {
            RuleFor(v => v.NombreEmpleado)
                .MaximumLength(200)
                .NotEmpty();
        }
    }
}
