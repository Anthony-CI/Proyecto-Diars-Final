using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.Models
{
    public class Gasto
    {
        public int IdGasto { get; set; }
        public string Nombre { get; set; }
        public decimal Monto { get; set; }
        

        //relacion con Cuenta
        public int CuentaId { get; set; }
        public Cuenta Cuenta { get; set; }
    }
}
