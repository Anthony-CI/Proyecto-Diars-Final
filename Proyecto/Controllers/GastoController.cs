using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using Proyecto.DB;
using Proyecto.Extensions;
using Proyecto.Models;

namespace Proyecto.Controllers
{
 
    public class GastoController : Controller
    {
        public IActionResult Index(int cuentaId)
        {
            var userLogged = HttpContext.Session.Get<Usuario>("SessionLoggedUser");
            var contex = new AppPruebaContex();
            var model = contex.Cuentas
                .Include(x => x.Gastos)
                .Where(x => x.IdCuenta == cuentaId && x.UsuarioId == userLogged.IdUsuario)
                .FirstOrDefault();
            return View(model);
        }

        [HttpGet]
        public IActionResult Crear(int cuentaId)
        {
            
            var contex = new AppPruebaContex();
            ViewBag.CuentaId = cuentaId;
            return View(new Gasto());



        }

        [HttpPost]
        public IActionResult Crear(Gasto gasto)
        {
            var contex = new AppPruebaContex();
            //var userLogged = HttpContext.Session.Get<Usuario>("SessionLoggedUser");
            //gasto.Cuenta.UsuarioId = userLogged.IdUsuario;
            var cuenta = contex.Cuentas
                .Include(c=>c.Gastos)
                .FirstOrDefault(c => c.IdCuenta == gasto.CuentaId);
            
            if (cuenta.SaldoFinal>=gasto.Monto)
            {
                contex.Gastos.Add(gasto);
                contex.SaveChanges();
                return RedirectToAction("Index", new { cuentaId = gasto.CuentaId });
            }
            ViewBag.CuentaId = cuenta.IdCuenta;
            return View(gasto);

        }
    }
}