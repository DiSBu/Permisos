using Permisos.Application.Common.Interfaces;
using System;

namespace Permisos.WebUI.IntegrationTests
{
    public class TestDateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
