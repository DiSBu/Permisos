using Permisos.Application.Common.Exceptions;
using Permisos.Application.Common.Interfaces;
using Permisos.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Permisos.Application.PermisoLists.Commands.DeletePermisoList
{
    public class DeletePermisoListCommand : IRequest
    {
        public int Id { get; set; }

        public class DeletePermisoListCommandHandler : IRequestHandler<DeletePermisoListCommand>
        {
            private readonly IApplicationDbContext _context;

            public DeletePermisoListCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(DeletePermisoListCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.PermisoLists
                    .Where(l => l.Id == request.Id)
                    .SingleOrDefaultAsync(cancellationToken);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(PermisoList), request.Id);
                }

                _context.PermisoLists.Remove(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return Unit.Value;
            }
        }
    }
}
