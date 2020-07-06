using System;
using System.Collections.Generic;
//using System.Data.Entity; genera problemas no usar
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyecto.DB;
using Proyecto.Extensions;
using Proyecto.Models;

namespace Proyecto.Controllers
{
    [Authorize]
    public class CuentaController : Controller
    {
        public IActionResult Index()
        {
            var userLogged = HttpContext.Session.Get<Usuario>("SessionLoggedUser");
            var contex = new AppPruebaContex();
            var model = contex.Cuentas
                .Include(o => o.TipoCuenta)
                .Include(o=>o.EntidadEmidora)
                .Include(o=>o.MetodoPago)
                .Where(o => o.UsuarioId == userLogged.IdUsuario)
                .ToList();
            return View(model);
        }


        [HttpGet]
        public IActionResult Crear()
        {
            var contex = new AppPruebaContex();
            ViewBag.TipoCuenta = contex.TipoCuentas.ToList();
            ViewBag.EntidadEmisora = contex.EntidadEmidoras.ToList();
            ViewBag.MetodoPago = contex.MetodoPagos.ToList();
            return View(new Cuenta());
        }

        [HttpPost]
        public IActionResult Crear(Cuenta cuenta)
        {
            var userLogged = HttpContext.Session.Get<Usuario>("SessionLoggedUser");
            var contex = new AppPruebaContex();
            ViewBag.TipoCuenta = contex.TipoCuentas.ToList();
            ViewBag.EntidadEmisora = contex.EntidadEmidoras.ToList();
            ViewBag.MetodoPago = contex.MetodoPagos.ToList();
            cuenta.UsuarioId = userLogged.IdUsuario;
            contex.Cuentas.Add(cuenta);
            contex.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Efectivo()
        {
            var contex = new AppPruebaContex();
            ViewBag.TipoCuenta = contex.TipoCuentas.ToList();
            return View(new Cuenta());
        }


        [HttpGet]
        public IActionResult CuentaBancaria()
        {
            var contex = new AppPruebaContex();
            ViewBag.TipoCuenta = contex.TipoCuentas.ToList();
            return View(new Cuenta());
        }

        [HttpGet]
        public IActionResult TarjetaDébito()
        {
            var contex = new AppPruebaContex();
            ViewBag.TipoCuenta = contex.TipoCuentas.ToList();
            ViewBag.EntidadEmisora = contex.EntidadEmidoras.ToList();
            return View(new Cuenta());
        }

        [HttpGet]
        public IActionResult TarjetaCrédito()
        {
            var contex = new AppPruebaContex();
            ViewBag.TipoCuenta = contex.TipoCuentas.ToList();
            ViewBag.EntidadEmisora = contex.EntidadEmidoras.ToList();
            return View(new Cuenta());
        }

        [HttpGet]
        public IActionResult Electronica()
        {
            var contex = new AppPruebaContex();
            ViewBag.TipoCuenta = contex.TipoCuentas.ToList();
            ViewBag.MetodoPago = contex.MetodoPagos.ToList();
            return View(new Cuenta());
        }

        [HttpGet]
        public IActionResult Activo()
        {
            var contex = new AppPruebaContex();
            ViewBag.TipoCuenta = contex.TipoCuentas.ToList();
            return View(new Cuenta());
        }

        [HttpGet]
        public IActionResult Pasivo()
        {
            var contex = new AppPruebaContex();
            ViewBag.TipoCuenta = contex.TipoCuentas.ToList();
            return View(new Cuenta());
        }

        [HttpGet]
        public IActionResult Indefinida()
        {
            var contex = new AppPruebaContex();
            ViewBag.TipoCuenta = contex.TipoCuentas.ToList();
            return View(new Cuenta());
        }
    }
}