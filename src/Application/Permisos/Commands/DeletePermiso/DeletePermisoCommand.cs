using Permisos.Application.Common.Exceptions;
using Permisos.Application.Common.Interfaces;
using Permisos.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Permisos.Application.Permisos.Commands.DeletePermiso
{
    public class DeletePermisoCommand : IRequest
    {
        public long Id { get; set; }

        public class DeletePermisoCommandHandler : IRequestHandler<DeletePermisoCommand>
        {
            private readonly IApplicationDbContext _context;

            public DeletePermisoCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(DeletePermisoCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.Permisos.FindAsync(request.Id);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(Permiso), request.Id);
                }

                _context.Permisos.Remove(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return Unit.Value;
            }
        }
    }
}
