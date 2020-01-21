using AutoMapper;
using Permisos.Application.Common.Mappings;
using Permisos.Domain.Entities;

namespace Permisos.Application.PermisoLists.Queries.GetPermisos
{
    public class PermisoDto : IMapFrom<Permiso>
    {
        public long Id { get; set; }

        public int ListId { get; set; }

        public string Title { get; set; }

        public bool Done { get; set; }

        public int Priority { get; set; }

        public string Note { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Permiso, PermisoDto>();
                //.ForMember(d => d.Priority, opt => opt.MapFrom(s => (int)s.Priority));
        }
    }
}
