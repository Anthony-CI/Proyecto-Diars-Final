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
        public DbSet<EntidadEmidora> EntidadEmidoras { get; set; }
        public DbSet<MetodoPago> MetodoPagos { get; set; }
        public DbSet<Gasto> Gastos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=Proyecto;Trusted_Connection=True;MultipleActiveResultSets=true");
            
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
        }
    }
}
