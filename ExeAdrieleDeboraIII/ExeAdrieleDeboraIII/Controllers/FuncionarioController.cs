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
            ViewBag.Titulo = "Funcionário Cadastrado";
            TempData["Alerta"] = "";
            ViewBag.IdFunc = func["IdFunc"];
            ViewBag.Nome = func["Nome"];
            ViewBag.Funcao = func["Funcao"];

            if (ViewBag.IdFunc == "" && ViewBag.Nome == "" && ViewBag.Funcao == "")
            {
                return RedirectToAction("Cadastrar", "Funcionario");
            }
            else if (ViewBag.IdFUnc != null && ViewBag.Nome == "" && ViewBag.Funcao == "")
            {
                TempData["Alerta"] = "O campo Nome deve ser preenchido!";
                return RedirectToAction("Cadastrar", "Funcionario");
            }
            else if (ViewBag.IdFUnc != null && ViewBag.Nome != null && ViewBag.Funcao == "")
            {
                TempData["Alerta"] = "O campo Função deve ser preenchido!";
                return RedirectToAction("Cadastrar", "Funcionario");
            }
            else if (ViewBag.IdFUnc == "" && ViewBag.Nome != null && ViewBag.Funcao != null)
            {
                TempData["Alerta"] = "O campo Código deve ser preenchido!";
                return RedirectToAction("Cadastrar", "Funcionario");
            }
            else if (ViewBag.IdFUnc != null && ViewBag.Nome == "" && ViewBag.Funcao != null)
            {
                TempData["Alerta"] = "O campo Nome deve ser preenchido!";
                return RedirectToAction("Cadastrar", "Funcionario");
            }
            else
            {
                return View();
            }

            
            
                
            

            

        }


    }
}