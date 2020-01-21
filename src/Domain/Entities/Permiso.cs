using System;

namespace Permisos.Domain.Entities
{
    public class Permiso 
    {
        public long Id { get; set; }

        public string NombreEmpleado { get; set; }

        public string ApellidosEmpleado { get; set; }

        public TipoPermiso TipoPermiso { get; set; }

        public DateTime FechaPermiso { get; set; }
    }
}
