using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proyecto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.DB.Configuracion
{
    public class EntidadEmidoraConfiguracion : IEntityTypeConfiguration<EntidadEmisora>
    {
        public void Configure(EntityTypeBuilder<EntidadEmisora> builder)
        {
            builder.ToTable("EntidadEmisora");
            builder.HasKey(o => o.IdEntidadEmisora);
            builder.Property(o => o.Nombre).HasColumnName("Nombre");
        }
    }
}
