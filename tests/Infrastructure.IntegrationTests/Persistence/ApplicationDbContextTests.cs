﻿using Permisos.Application.Common.Interfaces;
using Permisos.Domain.Entities;
using Permisos.Infrastructure.Persistence;
using IdentityServer4.EntityFramework.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Moq;
using Shouldly;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Permisos.Infrastructure.IntegrationTests.Persistence
{
    public class ApplicationDbContextTests : IDisposable
    {
        private readonly string _userId;
        private readonly DateTime _dateTime;
        private readonly Mock<IDateTime> _dateTimeMock;
        private readonly Mock<ICurrentUserService> _currentUserServiceMock;
        private readonly ApplicationDbContext _sut;

        public ApplicationDbContextTests()
        {
            _dateTime = new DateTime(3001, 1, 1);
            _dateTimeMock = new Mock<IDateTime>();
            _dateTimeMock.Setup(m => m.Now).Returns(_dateTime);

            _userId = "00000000-0000-0000-0000-000000000000";
            _currentUserServiceMock = new Mock<ICurrentUserService>();
            _currentUserServiceMock.Setup(m => m.UserId).Returns(_userId);

            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            var operationalStoreOptions = Options.Create(
                new OperationalStoreOptions
                {
                    DeviceFlowCodes = new TableConfiguration("DeviceCodes"),
                    PersistedGrants = new TableConfiguration("PersistedGrants")
                });

            _sut = new ApplicationDbContext(options, operationalStoreOptions, _currentUserServiceMock.Object, _dateTimeMock.Object);

            _sut.Permisos.Add(new Permiso
            {
                Id = 1
            });

            _sut.SaveChanges();
        }

        [Fact]
        public async Task SaveChangesAsync_GivenNewPermiso_ShouldSetCreatedProperties()
        {
            var item = new Permiso
            {
                Id = 2
            };

            _sut.Permisos.Add(item);

            await _sut.SaveChangesAsync();

        }

        [Fact]
        public async Task SaveChangesAsync_GivenExistingPermiso_ShouldSetLastModifiedProperties()
        {
            long id = 1;

            var item = await _sut.Permisos.FindAsync(id);

            await _sut.SaveChangesAsync();
        }

        public void Dispose()
        {
            _sut?.Dispose();
        }
    }
}
