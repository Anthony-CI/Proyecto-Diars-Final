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
using Proyecto.ViewModels;

namespace Proyecto.Controllers
{
    [Authorize]
    public class CuentaController : Controller
    {
        public IActionResult Index()
        {
            var userLogged = HttpContext.Session.Get<Usuario>("SessionLoggedUser");
            var contex = new AppPruebaContex();
            var cuentas = contex.Cuentas
                .Include(o => o.TipoCuenta)
                .Include(o => o.CuentaEntidadEmisora)
                .Include(o => o.CuentaMetodoPago)
                .Include(o=>o.Gastos)
                .Where(o => o.UsuarioId == userLogged.IdUsuario)
                .ToList();
            var viewModels = new List<CuentaViewModel>();

            foreach (var cuenta in cuentas)
            {
                var cuentaViewModel = new CuentaViewModel
                {
                    Cuenta = cuenta,
                    EntidadEmisora = cuenta.CuentaEntidadEmisora.Any() ?
                         contex.EntidadEmisoras.FirstOrDefault(
                           e => e.IdEntidadEmisora == cuenta.CuentaEntidadEmisora.FirstOrDefault().EntidadEmidoraId)
                    : new EntidadEmisora(),

                    MetodoPago = cuenta.CuentaMetodoPago.Any() ?
                        contex.MetodoPagos.FirstOrDefault(
                          m => m.IdMetodoPago == cuenta.CuentaMetodoPago.FirstOrDefault().MetodoPagoId)
                   : new MetodoPago(),
                };
                viewModels.Add(cuentaViewModel);
            }
            return View(viewModels);
        }


        [HttpGet]
        public IActionResult Crear()
        {
            var contex = new AppPruebaContex();
            ViewBag.TipoCuenta = contex.TipoCuentas.ToList();
            ViewBag.EntidadEmisora = contex.EntidadEmisoras.ToList();
            ViewBag.MetodoPago = contex.MetodoPagos.ToList();
            return View(new Cuenta());
        }

        [HttpPost]
        public IActionResult Crear(Cuenta cuenta)
        {
            var userLogged = HttpContext.Session.Get<Usuario>("SessionLoggedUser");
            var contex = new AppPruebaContex();
            ViewBag.TipoCuenta = contex.TipoCuentas.ToList();
            ViewBag.EntidadEmisora = contex.EntidadEmisoras.ToList();
            ViewBag.MetodoPago = contex.MetodoPagos.ToList();
            cuenta.UsuarioId = userLogged.IdUsuario;
            
            contex.Cuentas.Add(cuenta);
            contex.SaveChanges();

            var entidadEmisoraIngresada = HttpContext.Request.Form["EntidadEmidoraId"];
            if (!string.IsNullOrEmpty(entidadEmisoraIngresada) )
            {
                var cuentaEntidadEmisora = new CuentaEntidadEmisora
                {
                    Cuenta = cuenta,
                    EntidadEmidoraId = Int32.Parse(entidadEmisoraIngresada)

                };
                contex.CuentaEntidadEmisoras.Add(cuentaEntidadEmisora);
                contex.SaveChanges();
            }


            var metodoPagoIngresada = HttpContext.Request.Form["MetodoPagoId"];
            if (!string.IsNullOrEmpty (metodoPagoIngresada))
            {


                var cuentaMetodoPago = new CuentaMetodoPago
                {
                    Cuenta = cuenta,
                    MetodoPagoId = Int32.Parse(metodoPagoIngresada)

                };

                contex.CuentaMetodoPagos.Add(cuentaMetodoPago);
                contex.SaveChanges();
            }
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
            ViewBag.EntidadEmisora = contex.EntidadEmisoras.ToList();
            return View(new Cuenta());
        }

        [HttpGet]
        public IActionResult TarjetaCrédito()
        {
            var contex = new AppPruebaContex();
            ViewBag.TipoCuenta = contex.TipoCuentas.ToList();
            ViewBag.EntidadEmisora = contex.EntidadEmisoras.ToList();
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