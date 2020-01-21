using Permisos.Application.Common.Interfaces;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Permisos.Application.PermisoLists.Commands.CreatePermisoList
{
    public class CreatePermisoListCommandValidator : AbstractValidator<CreatePermisoListCommand>
    {
        private readonly IApplicationDbContext _context;

        public CreatePermisoListCommandValidator(IApplicationDbContext context)
        {
            _context = context;

            RuleFor(v => v.Id)
                .NotNull().WithMessage("Permiso is required.")
                .MustAsync(BeUniquePermiso).WithMessage("The specified Permiso already exists.");
        }

        public async Task<bool> BeUniquePermiso(int id, CancellationToken cancellationToken)
        {
            return await _context.PermisoLists
                .AllAsync(l => l.Id != id);
        }
    }
}
