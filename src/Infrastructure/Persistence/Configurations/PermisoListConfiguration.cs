
using Permisos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Permisos.Infrastructure.Persistence.Configurations
{
    public class PermisoListConfiguration : IEntityTypeConfiguration<PermisoList>
    {
        public void Configure(EntityTypeBuilder<PermisoList> builder)
        {
            builder.Property(t => t.Id)
                //.HasMaxLength(200)
                .IsRequired();
        }
    }
}
