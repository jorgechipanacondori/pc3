using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PC3.Data;
using PC3.Models;

namespace Practica3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger,ApplicationDbContext context)
        {
            _logger = logger;
            _context=context;
        }

        public IActionResult Index()
        {
      
            DateTime now = DateTime.Today;
            now=now.AddDays(+1);
            DateTime semana = now.AddDays(-7);
            
            
            var registro = _context.Registrar.Where(x => x.Fecha>=semana && x.Fecha<=now).ToList();
            

            return View(registro);
        }
          public IActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Ingresar(Registrar objCliente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(objCliente);
                _context.SaveChanges();
                return RedirectToAction("Index");

            }
            return View("Regitrar", objCliente);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
