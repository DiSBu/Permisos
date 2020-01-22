using Permisos.Application.Common.Mappings;
using Permisos.Domain.Entities;
using System.Collections.Generic;

namespace Permisos.Application.PermisoLists.Queries.GetPermisos
{
    public class PermisoListDto : IMapFrom<PermisoList>
{
    public PermisoListDto()
    {
        Items = new List<PermisoDto>();
    }

    public int Id { get; set; }

    public IList<PermisoDto> Items { get; set; }
}
}
