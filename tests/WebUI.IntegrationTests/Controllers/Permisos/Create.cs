using Permisos.Application.Permisos.Commands.CreatePermiso;
using Shouldly;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace Permisos.WebUI.IntegrationTests.Controllers.Permisos
{
    public class Create : IClassFixture<CustomWebApplicationFactory<Startup>>
    {
        private readonly CustomWebApplicationFactory<Startup> _factory;

        public Create(CustomWebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task GivenValidCreatePermisoCommand_ReturnsSuccessCode()
        {
            var client = await _factory.GetAnonymousClient();

            var command = new CreatePermisoCommand
            {
                NombreEmpleado = "Pete"
            };

            var content = IntegrationTestHelper.GetRequestContent(command);

            var response = await client.PostAsync($"/api/Permisos", content);

            response.EnsureSuccessStatusCode();
        }

        [Fact]
        public async Task GivenInvalidCreatePermisoCommand_ReturnsBadRequest()
        {
            var client = await _factory.GetAnonymousClient();

            var command = new CreatePermisoCommand
            {
                NombreEmpleado = "NameNameNameNameNameNameNameNameNameNameNameNameNameNameNameNameNameNameNameNameNameNameNameNameNameNameNameNameNameNameNameNameNameNameNameNameNameNameNameNameNameNameNameNameNameNameNameNameNameNameNameNameNameNameNameNameNameNameNameNameNameNameNameNameNameNameNameNameNameNameNameNameNameName"
            };

            var content = IntegrationTestHelper.GetRequestContent(command);

            var response = await client.PostAsync($"/api/Permisos", content);

            response.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
        }
    }
}
