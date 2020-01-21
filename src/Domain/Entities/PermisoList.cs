using System.Collections.Generic;

namespace Permisos.Domain.Entities
{
    public class PermisoList 
    {
        public PermisoList()
        {
            Items = new List<Permiso>();
        }

        public int Id { get; set; }

        public IList<Permiso> Items { get; set; }
    }
}
