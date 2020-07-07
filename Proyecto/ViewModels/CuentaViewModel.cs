using Proyecto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.ViewModels
{
    public class CuentaViewModel
    {
        
        public Cuenta Cuenta { get; set; }
        public EntidadEmisora EntidadEmisora { get; set; }
        public  MetodoPago MetodoPago { get; set; }
    }
}
