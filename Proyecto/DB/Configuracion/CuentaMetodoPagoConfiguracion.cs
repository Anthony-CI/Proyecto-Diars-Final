using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proyecto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.DB.Configuracion
{
    public class CuentaMetodoPagoConfiguracion : IEntityTypeConfiguration<CuentaMetodoPago>
    {
        public void Configure(EntityTypeBuilder<CuentaMetodoPago> builder)
        {
            builder.HasKey(o => o.IdCuentaMetodoPago);
        }
    }
}
