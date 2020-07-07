using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.Models
{
    public class EntidadEmisora
    {
        public int IdEntidadEmisora { get; set; }
        public string Nombre { get; set; }

        //crear la relacion con cuenta
        public List<CuentaEntidadEmisora> CuentaEntidadEmisora { get; set; }
    }
}
