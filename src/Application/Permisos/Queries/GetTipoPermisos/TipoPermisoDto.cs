using AutoMapper;
using Permisos.Application.Common.Mappings;
using Permisos.Domain.Entities;
using System;

namespace Permisos.Application.Permisos.Queries.GetTipoPermisos
{
    public class TipoPermisoDto : IMapFrom<TipoPermiso>
    {
        public int Id { get; set; }

        public string Descripcion { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<TipoPermiso, TipoPermisoDto>();
        }
    }
}
