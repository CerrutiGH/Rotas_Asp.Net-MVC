using System;
using System.Collections.Generic;
using System.Linq;
using Exercicio_GabrielCerruti.Connection;
using System.Web;
using System.Web.Mvc;
using Exercicio_GabrielCerruti.Models;

namespace Exercicio_GabrielCerruti.Controllers
{
    public class HomeController : Controller
    {
        AcoesNoticias acoes = new AcoesNoticias();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CadastrarNoticias()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CadastrarNoticias(Noticias insnot)
        {
            if (ModelState.IsValid)
            {
                acoes.InsertNoticia(insnot);
                return RedirectToAction("Index", "Home");
            }
            return View(insnot);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult IndexNoticia()
        {
            
            ViewBag.DadosCategorias = acoes.ListarTresUltimos();
            ViewBag.DadosNoticias = acoes.ListarCategorias();
            return View();
        }

       


      
    }
}