using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.Models
{
    public class CuentaEntidadEmisora
    {
        public int IdCuentaEntidadEmisora { get; set; }
        //relacion entidad
        public int EntidadEmidoraId { get; set; }
        public EntidadEmisora EntidadEmidora { get; set; }

        public  Cuenta Cuenta  { get; set; }
        public int CuentaId { get; set; }
    }
}
