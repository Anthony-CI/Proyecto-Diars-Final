using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proyecto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.DB.Configuracion
{
    public class TransferenciaConfiguracion : IEntityTypeConfiguration<Transferencia>
    {
        public void Configure(EntityTypeBuilder<Transferencia> builder)
        {
            builder.HasKey(o => o.IdTransferencia);

            builder.HasOne(o => o.CuentaOrigen)
                .WithMany(o => o.TransferenciasComoOrigen)
                //.HasForeignKey(o => o.CuentaOrigenId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(o => o.CuentaDestino)
                .WithMany(o => o.TransferenciasComoDestino)
                //.HasForeignKey(o => o.CuentaDestinoId)
                .OnDelete(DeleteBehavior.NoAction);


        }
    }
}
