using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyecto.DB;
using Proyecto.Extensions;
using Proyecto.Models;

namespace Proyecto.Controllers
{
    public class TransferenciasController : Controller
    {
        public IActionResult Index(int cuentaId)
        {
            var userLogged = HttpContext.Session.Get<Usuario>("SessionLoggedUser");
            var contex = new AppPruebaContex();
            var model = contex.Cuentas
                .Include(x => x.TransferenciasComoDestino)
                .Include(x => x.TransferenciasComoOrigen)
                .Include(x => x.Gastos)
                .Where(x => x.IdCuenta == cuentaId && x.UsuarioId == userLogged.IdUsuario)
                .FirstOrDefault();
            return View(model);
        }


        [HttpGet]
        public IActionResult Crear(int cuentaId)
        {

            var contex = new AppPruebaContex();
            var userLogged = HttpContext.Session.Get<Usuario>("SessionLoggedUser");
            
            var cuentas = contex.Cuentas
                .Where(o => o.UsuarioId == userLogged.IdUsuario)
                .ToList();
            ViewBag.CuentaId = cuentaId;
            ViewBag.Cuentas = cuentas;
            return View(new Transferencia());



        }

        [HttpPost]
        public IActionResult Crear(Transferencia transferencia)
        {
            var contex = new AppPruebaContex();
            //var userLogged = HttpContext.Session.Get<Usuario>("SessionLoggedUser");
            //gasto.Cuenta.UsuarioId = userLogged.IdUsuario;
            var cuenta = contex.Cuentas
                .Include(c => c.Gastos)
                .Include(c => c.TransferenciasComoDestino)
                .Include(c => c.TransferenciasComoOrigen)
                .FirstOrDefault(c => c.IdCuenta == transferencia.CuentaOrigenId);

            if (cuenta.SaldoFinal >= transferencia.Monto)
            {
                contex.Transferencias.Add(transferencia);
                contex.SaveChanges();
                return RedirectToAction("Index", new { cuentaId = transferencia.CuentaOrigenId });
            }
            ViewBag.CuentaId = transferencia.CuentaOrigenId;
            return RedirectToAction("Crear",new { cuentaId = transferencia.CuentaOrigenId });

        }
    }
}