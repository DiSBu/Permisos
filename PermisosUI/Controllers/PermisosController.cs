
using Permisos.Application.WeatherForecasts.Queries.GetWeatherForecasts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Permisos.Application.Permisos.Queries.GetPermisos;

namespace Permisos.WebUI.Controllers
{
    [Authorize]
    public class PermisosController : ApiController
    {
        [AllowAnonymous]
        [HttpGet]
        public async Task<PermisosVm> Get()
        {
            return await Mediator.Send(new GetPermisosQuery());
        }
    }
}