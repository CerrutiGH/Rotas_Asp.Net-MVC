using System.Web;
using System.Web.Mvc;

namespace Exercicio_GabrielCerruti
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
