using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VentaAutomoviles.Controllers
{
    public class AdministradorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult agregarEditarCarro()
        {
            return View();
        }

        public IActionResult procesarSolicitudes()
        {
            return View();
        }
    }
}