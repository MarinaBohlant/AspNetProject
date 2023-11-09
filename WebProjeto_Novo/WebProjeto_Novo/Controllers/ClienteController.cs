using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProjeto_Novo.Models;

namespace WebProjeto_Novo.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            var cliente = new Models.Cliente();
            return View(cliente);
        }

        [HttpPost]
        public ActionResult Index(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                return View("Resultado", cliente);
            }
            return View(cliente);
        }
        public ActionResult Resultado(Cliente cliente)
        {
            return View(cliente);
        }
    }
}