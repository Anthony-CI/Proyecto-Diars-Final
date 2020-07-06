using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.Models
{
    public class EntidadEmidora
    {
        public int IdEntidadEmidora { get; set; }
        public string Nombre { get; set; }

        //crear la relacion con cuenta
        public List<Cuenta> Cuentas { get; set; }
    }
}
