using Permisos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Permisos.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<PermisoList> PermisoLists { get; set; }

        DbSet<Permiso> Permisos { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
