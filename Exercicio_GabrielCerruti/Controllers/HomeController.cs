using System;
using System.Collections.Generic;
using System.Linq;
using Exercicio_GabrielCerruti.Connection;
using System.Web;
using System.Web.Mvc;

namespace Exercicio_GabrielCerruti.Controllers
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

        public ActionResult IndexNoticia()
        {
            var exibirNot = new AcoesNoticias();
            ViewBag.DadosCategorias = exibirNot.ListarTresUltimos();
            ViewBag.DadosNoticias = exibirNot.ListarCategorias();
            return View();
        }
    }
}