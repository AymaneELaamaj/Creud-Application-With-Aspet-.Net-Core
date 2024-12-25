using Microsoft.AspNetCore.Mvc;

namespace FIRST_DOTNET_PROEJCT.Controllers
{
    public class ProduitController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
