using ExeAdrieleDeboraIII.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExeAdrieleDeboraIII.Areas.Veiculo.Controllers
{
    public class AutoController : Controller
    {
        // GET: Veiculo/Auto
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Moto()
        {
            ViewBag.Titulo = "Moto";

            Moto moto = new Moto()
            {
                Fabricante = "Ducati",
                Transmissao = "Automatica",
                Categoria = "Sport",
                Cilindrada = 998,

            };

            return View(moto);

        }

        public ActionResult Carro()
        {

            ViewBag.Titulo = "Carro";

            Carro carro = new Carro()
            {
                Fabricante = "Chevrollet",
                Transmissao = "Automatica",
                Tipo = "Coupe",
                Nome = "Camaro"
            };

            return View(carro);
        }

        public ActionResult Veiculo()
        {
            ViewBag.Titulo = "Veiculos";

            Moto moto = new Moto()
            {
                Fabricante = "Ducati",
                Transmissao = "Automatica",
                Categoria = "Sport",
                Cilindrada = 998,

            };

            Carro carro = new Carro()
            {
                Fabricante = "Chevrollet",
                Transmissao = "Automatica",
                Tipo = "Coupe",
                Nome = "Camaro"
            };

            ViewBag.Fabricante = carro.Fabricante;
            ViewBag.Transmissao = carro.Transmissao;
            ViewBag.Tipo = carro.Tipo;
            ViewBag.Nome = carro.Nome;


            return View(moto);
        }
    }
}