using ExeAdrieleDeboraIII.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace ExeAdrieleDeboraIII.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Inicio()
        {
            ViewBag.Message = "Página Inicial";

            return View();
        }

        public ActionResult Nota() 
        {
            ViewBag.Titulo = "Calculando minha nota";
            Notas objnotas = new Notas();  

            return View(objnotas);
        }

        [HttpPost]
        public ActionResult Resultado(FormCollection objnotas)
        {
            ViewBag.Titulo = "CalculaNota";
            ViewBag.Numero = objnotas["Valor"];

            if (ViewBag.Numero == "")
            {
                return RedirectToAction("Nota", "Home");
            }

            int notas = int.Parse(ViewBag.Numero);
            ViewBag.Resultado = (10 - notas) ;
            return  View();
        }
    }
}