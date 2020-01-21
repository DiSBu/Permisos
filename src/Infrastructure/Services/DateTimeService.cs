using Permisos.Application.Common.Interfaces;
using System;

namespace Permisos.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
