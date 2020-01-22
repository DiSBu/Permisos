using AutoMapper;
using Permisos.Application.Common.Mappings;
using Permisos.Domain.Entities;
using System;

namespace Permisos.Application.Permisos.Queries.GetPermisos
{
    public class PermisoDto : IMapFrom<Permiso>
    {
        public long Id { get; set; }

        public string NombreEmpleado { get; set; }

        public string ApellidosEmpleado { get; set; }

        public TipoPermiso TipoPermiso { get; set; }

        public DateTime FechaPermiso { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Permiso, PermisoDto>();
                //.ForMember(d => d.Priority, opt => opt.MapFrom(s => (int)s.Priority));
        }
    }
}
