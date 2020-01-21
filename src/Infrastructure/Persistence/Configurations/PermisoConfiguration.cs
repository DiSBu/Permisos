using Permisos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Permisos.Infrastructure.Persistence.Configurations
{
    public class PermisoConfiguration : IEntityTypeConfiguration<Permiso>
    {
        public void Configure(EntityTypeBuilder<Permiso> builder)
        {
            builder.Property(t => t.Id)
                //.HasMaxLength(200)
                .IsRequired();
        }
    }
}
