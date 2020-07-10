using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Proyecto.DB;
using Proyecto.Extensions;
using Proyecto.Models;

namespace Proyecto.Controllers
{
    public class AuthController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string UserName, string Password)
        {
            var context = new AppPruebaContex();

            var user = context.Usuarios.FirstOrDefault(o => o.NombreUsuario == UserName && o.Contraseña == Password);

            if (user == null)
            {
                return View();
            }

            HttpContext.Session.Set("SessionLoggedUser", user);

            var claims = new List<Claim>() {
                new Claim(ClaimTypes.Name, user.NombreUsuario),

            };

            var userIdentity = new ClaimsIdentity(claims, "Login");
            var principal = new ClaimsPrincipal(userIdentity);

            HttpContext.SignInAsync(principal);

            return RedirectToAction("Index", "Cuenta");
        }

        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            return RedirectToAction("Login", "AUth");
        }


        [HttpPost]
        public ActionResult Crear(Usuario usuario )
        {


            var context = new AppPruebaContex();
            context.Usuarios.Add(usuario);
            context.SaveChanges();
            return RedirectToAction("Login", "AUth");
            
            
        }

        [HttpGet]
        public ActionResult Crear()
        {


            return View(new Usuario());
        }



    }
}