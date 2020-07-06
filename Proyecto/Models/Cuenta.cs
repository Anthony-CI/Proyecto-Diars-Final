using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.Models
{
    public class Cuenta
    {
        public int IdCuenta { get; set; }
        public string Nombre { get; set; }
        public double SaldoInicial { get; set; }
        public string Concepto { get; set; }
        public string Entidad { get; set; }

        public int NumeroTarjeta { get; set; }

        public DateTime DiaCierre { get; set; }
        public DateTime DiaPago { get; set; }
        public double LimiteCredito { get; set; }
        




        //relacion con tipo de cuenta
        public int TipoCuentaId { get; set; }
        public TipoCuenta TipoCuenta { get; set; }


        //relacion con Entidad Emisora
        public int? EntidadEmidoraId { get; set; }
        public EntidadEmidora EntidadEmidora { get; set; }

        //relacion con metodo de pago
        public int? MetodoPagoId { get; set; }
        public MetodoPago MetodoPago { get; set; }



        //relacion con usuario
        public int UsuarioId { get; set; }

        //crear la relacion con Gasto
        public List<Gasto> Gastos { get; set; }



    }
}
