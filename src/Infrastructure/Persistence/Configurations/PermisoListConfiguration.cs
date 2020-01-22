
using Permisos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Permisos.Infrastructure.Persistence.Configurations
{
    public class TipoPermisoConfiguration : IEntityTypeConfiguration<TipoPermiso>
    {
        public void Configure(EntityTypeBuilder<TipoPermiso> builder)
        {
            builder.Property(t => t.Id)
                //.HasMaxLength(200)
                .IsRequired();
        }
    }
}
