
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Permisos.Application.Permisos.Queries.GetPermisos;
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

        [HttpPost]
        public async Task<long> Post()
        {
            return await Mediator.Send(new CreatePermisoCommand());
        }
    }
}