using AutoMapper;
using AutoMapper.QueryableExtensions;
using Permisos.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Permisos.Application.Permisos.Queries.GetTipoPermisos
{
    public class GetTipoPermisosQuery : IRequest<TipoPermisosVm>
    {
        public class GetTipoPermisosQueryHandler : IRequestHandler<GetTipoPermisosQuery, TipoPermisosVm>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetTipoPermisosQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<TipoPermisosVm> Handle(GetTipoPermisosQuery request, CancellationToken cancellationToken)
            {
                var vm = new TipoPermisosVm();

                vm.Lists = await _context.TipoPermisos
                    .ProjectTo<TipoPermisoDto>(_mapper.ConfigurationProvider)
                    .OrderBy(t => t.Id)
                    .ToListAsync(cancellationToken);

                return vm;
            }
        }
    }
}
