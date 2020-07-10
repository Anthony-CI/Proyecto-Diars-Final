using Microsoft.EntityFrameworkCore;
using Proyecto.DB.Configuracion;
using Proyecto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Proyecto.DB
{
    public class AppPruebaContex : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cuenta> Cuentas { get; set; }

        public DbSet<TipoCuenta> TipoCuentas { get; set; }
        public DbSet<EntidadEmisora> EntidadEmisoras { get; set; }
        public DbSet<MetodoPago> MetodoPagos { get; set; }
        public DbSet<Gasto> Gastos { get; set; }
        public DbSet<CuentaEntidadEmisora> CuentaEntidadEmisoras { get; set; }
        public DbSet<CuentaMetodoPago> CuentaMetodoPagos { get; set; }
        public DbSet<Transferencia> Transferencias { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=Proyecto3;Trusted_Connection=True;MultipleActiveResultSets=true");
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UsuarioConfiguracion());
            modelBuilder.ApplyConfiguration(new CuentaConfiguracion());
            modelBuilder.ApplyConfiguration(new TipoCuentaConfiguracion());
            modelBuilder.ApplyConfiguration(new EntidadEmidoraConfiguracion());
            modelBuilder.ApplyConfiguration(new MetodoPagoConfiguracion());
            modelBuilder.ApplyConfiguration(new GastoConfiguracion());
            modelBuilder.ApplyConfiguration(new CuentaEntidadEmisoraConfiguracion());
            modelBuilder.ApplyConfiguration(new CuentaMetodoPagoConfiguracion());
            modelBuilder.ApplyConfiguration(new TransferenciaConfiguracion());
        }
    }
}
