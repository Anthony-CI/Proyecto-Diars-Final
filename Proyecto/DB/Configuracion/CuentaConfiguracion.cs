using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proyecto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.DB.Configuracion
{
    public class CuentaConfiguracion : IEntityTypeConfiguration<Cuenta>
    {
        public void Configure(EntityTypeBuilder<Cuenta> builder)
        {
            builder.ToTable("Cuenta");
            builder.HasKey(o => o.IdCuenta);

            builder.HasOne(o => o.TipoCuenta)
                .WithMany(o => o.Cuentas)
                .HasForeignKey(o => o.TipoCuentaId);

            builder.HasOne(o => o.EntidadEmidora)
                .WithMany(o => o.Cuentas)
                .HasForeignKey(o => o.EntidadEmidoraId);

            builder.HasOne(o => o.MetodoPago)
                .WithMany(o => o.Cuentas)
                .HasForeignKey(o => o.MetodoPagoId);
        }
    }
}
