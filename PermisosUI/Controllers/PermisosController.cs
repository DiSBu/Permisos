
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Permisos.Application.Permisos.Queries.GetPermisos;
using Permisos.Application.Permisos.Queries.GetTipoPermisos;
using Permisos.Application.Permisos.Commands.CreatePermiso;

namespace Permisos.WebUI.Controllers
{
    public class PermisosController : ApiController
    {
        [HttpGet]
        public async Task<PermisosVm> Get()
        {
            return await Mediator.Send(new GetPermisosQuery());
        }

        [HttpGet]
        [Route("api/TiposPermiso")]
        public async Task<TipoPermisosVm> GetTipos()
        {
            return await Mediator.Send(new GetTipoPermisosQuery());
        }

        [HttpPost]
        public async Task<ActionResult<long>> Post(CreatePermisoCommand createPermisoCommand)
        {
            return await Mediator.Send(createPermisoCommand);
        }
    }
}