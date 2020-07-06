using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proyecto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.DB.Configuracion
{
    public class EntidadEmidoraConfiguracion : IEntityTypeConfiguration<EntidadEmidora>
    {
        public void Configure(EntityTypeBuilder<EntidadEmidora> builder)
        {
            builder.ToTable("EntidadEmidora");
            builder.HasKey(o => o.IdEntidadEmidora);
            builder.Property(o => o.Nombre).HasColumnName("Nombre");
        }
    }
}
