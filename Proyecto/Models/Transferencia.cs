using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.Models
{
    public class Transferencia
    {
        public int IdTransferencia { get; set; }
        public int CuentaOrigenId { get; set; }
        public Cuenta CuentaOrigen { get; set; }
        public int CuentaDestinoId { get; set; }
        public Cuenta CuentaDestino { get; set; }

        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
    }
}
