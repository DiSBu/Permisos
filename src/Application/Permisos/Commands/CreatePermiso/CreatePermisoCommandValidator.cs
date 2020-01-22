using FluentValidation;

namespace Permisos.Application.Permisos.Commands.CreatePermiso
{
    public class CreatePermisoCommandValidator : AbstractValidator<CreatePermisoCommand>
    {
        public CreatePermisoCommandValidator()
        {
            RuleFor(v => v.ApellidosEmpleado)
                .MaximumLength(200)
                .NotEmpty();
            RuleFor(v => v.NombreEmpleado)
                .MaximumLength(200)
                .NotEmpty();
            RuleFor(v => v.FechaPermiso)
                .NotEmpty();
        }
    }
}
