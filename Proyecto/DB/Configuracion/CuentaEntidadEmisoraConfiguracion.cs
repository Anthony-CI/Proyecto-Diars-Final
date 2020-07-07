using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proyecto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.DB.Configuracion
{
    public class CuentaEntidadEmisoraConfiguracion : IEntityTypeConfiguration<CuentaEntidadEmisora>
    {
        public void Configure(EntityTypeBuilder<CuentaEntidadEmisora> builder)
        {
            //builder.ToTable("CuentaEntidadEmisora");
            builder.HasKey(o => o.IdCuentaEntidadEmisora);
        }
    }
}
