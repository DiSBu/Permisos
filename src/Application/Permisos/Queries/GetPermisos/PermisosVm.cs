//using Permisos.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Permisos.Application.Permisos.Queries.GetPermisos
{
    public class PermisosVm
    {
        //public IList<PriorityLevelDto> PriorityLevels =
        //    Enum.GetValues(typeof(PriorityLevel))
        //        .Cast<PriorityLevel>()
        //        .Select(p => new PriorityLevelDto { Value = (int)p, Name = p.ToString() })
        //        .ToList();

        public IList<PermisoDto> Lists { get; set; }
    }
}
