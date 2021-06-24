using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exercicio_GabrielCerruti.Areas.Aluno.Controllers
{
    public class AlunoController : Controller
    {
        // GET: Aluno/Home
        
        public ActionResult Aluno()
        {
            return View();
        }
    }
}