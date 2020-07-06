using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.Models
{
    public class MetodoPago
    {
        public int IdMetodoPago { get; set; }
        public string Nombre { get; set; }

        //crear la relacion con cuenta
        public List<Cuenta> Cuentas { get; set; }
    }
}
