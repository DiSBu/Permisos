using Permisos.Application.Common.Interfaces;
using Permisos.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Permisos.Application.PermisoLists.Commands.CreatePermisoList
{
    public partial class CreatePermisoListCommand : IRequest<int>
    {
        public int Id { get; set; }

        public class CreatePermisoListCommandHandler : IRequestHandler<CreatePermisoListCommand, int>
        {
            private readonly IApplicationDbContext _context;

            public CreatePermisoListCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<int> Handle(CreatePermisoListCommand request, CancellationToken cancellationToken)
            {
                var entity = new PermisoList();

                entity.Id = request.Id;

                _context.PermisoLists.Add(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return entity.Id;
            }
        }
    }
}
