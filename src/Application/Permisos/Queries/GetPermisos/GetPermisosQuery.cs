using AutoMapper;
using AutoMapper.QueryableExtensions;
using Permisos.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Permisos.Application.Permisos.Queries.GetPermisos
{
    public class GetPermisosQuery : IRequest<PermisosVm>
    {
        public class GetPermisosQueryHandler : IRequestHandler<GetPermisosQuery, PermisosVm>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetPermisosQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<PermisosVm> Handle(GetPermisosQuery request, CancellationToken cancellationToken)
            {
                var vm = new PermisosVm();

                vm.Lists = await _context.Permisos
                    .ProjectTo<PermisoDto>(_mapper.ConfigurationProvider)
                    .OrderBy(t => t.Id)
                    .ToListAsync(cancellationToken);

                return vm;
            }
        }
    }
}
