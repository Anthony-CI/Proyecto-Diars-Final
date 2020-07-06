using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proyecto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.DB.Configuracion
{
    public class GastoConfiguracion : IEntityTypeConfiguration<Gasto>
    {
        public void Configure(EntityTypeBuilder<Gasto> builder)
        {
            builder.ToTable("Gasto");
            builder.HasKey(o => o.IdGasto);

            builder.HasOne(o => o.Cuenta)
                .WithMany(o => o.Gastos)
                .HasForeignKey(o => o.CuentaId);
        }
    }
}
