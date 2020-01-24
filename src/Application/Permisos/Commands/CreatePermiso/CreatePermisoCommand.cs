using Permisos.Application.Common.Interfaces;
using Permisos.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace Permisos.Application.Permisos.Commands.CreatePermiso
{
    public class CreatePermisoCommand : IRequest<long>
    {
        public long Id { get; set; }

        public string NombreEmpleado { get; set; }

        public string ApellidosEmpleado { get; set; }

        public TipoPermiso TipoPermiso { get; set; }

        public DateTime FechaPermiso { get; set; }

        public class CreatePermisoCommandHandler : IRequestHandler<CreatePermisoCommand, long>
        {
            private readonly IApplicationDbContext _context;

            public CreatePermisoCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<long> Handle(CreatePermisoCommand request, CancellationToken cancellationToken)
            {                
                var entity = new Permiso
                {
                    Id = request.Id,
                    NombreEmpleado = request.NombreEmpleado,
                    ApellidosEmpleado = request.ApellidosEmpleado,
                    TipoPermiso = _context.TipoPermisos.Find(request.TipoPermiso.Id),
                    FechaPermiso = request.FechaPermiso
                };

                _context.Permisos.Add(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return entity.Id;
            }
        }
    }
}
