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
    }
}