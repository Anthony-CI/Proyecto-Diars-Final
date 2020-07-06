using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proyecto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.DB.Configuracion
{
    public class TipoCuentaConfiguracion : IEntityTypeConfiguration<TipoCuenta>
    {
        public void Configure(EntityTypeBuilder<TipoCuenta> builder)
        {
            builder.ToTable("TipoCuenta");
            builder.HasKey(o => o.IdTipoCuenta);
            builder.Property(o => o.Nombre).HasColumnName("Nombre");
        }
    }
}
