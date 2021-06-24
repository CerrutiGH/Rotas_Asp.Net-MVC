using System.Web.Mvc;
using Exercicio_GabrielCerruti.Connection;


namespace Exercicio_GabrielCerruti.Controllers
{
    
    public class NoticiasController : Controller
    {

        // GET: noticias
        public ActionResult Noticias()
        {
            var exibirNot = new AcoesNoticias();
            var TodasNot = exibirNot.ListarAllNoticia();
            return View(TodasNot);
        }

    
        public ActionResult LerNoticias(int id)
        {
            AcoesNoticias acoes = new AcoesNoticias();
            ViewBag.NoticiasBag = acoes.ListarNoticia(id);
            return View();
        }


        
        public ActionResult LerCategorias(string CAT)
        {
            AcoesNoticias acoes = new AcoesNoticias();
            ViewBag.NoticiasBag = acoes.ListarCategoriasNoticias(CAT);
            var Cate = acoes.ListarCat(CAT);
            return View(Cate);
        }

       


    }
}