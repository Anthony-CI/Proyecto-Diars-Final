using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proyecto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.DB.Configuracion
{
    public class MetodoPagoConfiguracion : IEntityTypeConfiguration<MetodoPago>
    {
        public void Configure(EntityTypeBuilder<MetodoPago> builder)
        {
            builder.ToTable("MetodoPago");
            builder.HasKey(o => o.IdMetodoPago);
            builder.Property(o => o.Nombre).HasColumnName("Nombre");
        }
    }
}
