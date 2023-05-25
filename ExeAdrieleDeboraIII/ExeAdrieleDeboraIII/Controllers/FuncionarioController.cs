using ExeAdrieleDeboraIII.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExeAdrieleDeboraIII.Controllers
{
    public class FuncionarioController : Controller
    {
        // GET: Funcionario
        public ActionResult Index()
        {
            ViewBag.Desculpa = "Desculpa!";
            ViewBag.Message = "Area em desenvolvimento clique em";
            return View();
        }

        public ActionResult Cadastrar()
        {
            ViewBag.Titulo = "Cadastre um Funcionário";
            Funcionario func = new Funcionario();
            return View(func);
        }

        [HttpPost]
        public ActionResult CadastroFunc(FormCollection func)
        {
            ViewBag.IdFunc = func["IdFunc"];
            ViewBag.Nome = func["Nome"];
            ViewBag.Funcao = func["Funcao"];
            return View();
        }
    }
}