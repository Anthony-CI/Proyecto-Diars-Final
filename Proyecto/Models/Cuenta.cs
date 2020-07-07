using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Proyecto.Models
{
    public class Cuenta
    {
        public int IdCuenta { get; set; }
        public string Nombre { get; set; }
        public decimal SaldoInicial { get; set; }
        public string Concepto { get; set; }
        public string Entidad { get; set; }

        public string NumeroTarjeta { get; set; }

        public DateTime DiaCierre { get; set; }
        public DateTime DiaPago { get; set; }
        public decimal LimiteCredito { get; set; }
        
        //relacion con tipo de cuenta
        public int TipoCuentaId { get; set; }
        public TipoCuenta TipoCuenta { get; set; }

        //relacion con usuario
        public int UsuarioId { get; set; }

        //crear la relacion con Gasto
        public List<Gasto> Gastos { get; set; }

        //
        public List<CuentaEntidadEmisora> CuentaEntidadEmisora { get; set; }
        //
        public List<CuentaMetodoPago> CuentaMetodoPago { get; set; }

        //saldo calcular gastos
        public decimal SaldoFinal { 
            get 
            {
                return SaldoInicial - TotalGastos;
            } 
        }
        public decimal TotalGastos
        {
            get
            {
                return Gastos.Aggregate(0m, (total, gastoActual) => total + gastoActual.Monto);
            }
        }
    
        public Cuenta()
        {
            CuentaEntidadEmisora = new List<CuentaEntidadEmisora>();
            CuentaMetodoPago = new List<CuentaMetodoPago>();
        }
    }
}
