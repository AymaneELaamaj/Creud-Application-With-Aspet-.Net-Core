using FIRST_DOTNET_PROEJCT.Data;
using FIRST_DOTNET_PROEJCT.Models;
using Microsoft.AspNetCore.Mvc;

namespace FIRST_DOTNET_PROEJCT.Controllers
{
    public class CategorieController : Controller
    {
        private readonly MyAppContextDb _db;
        public CategorieController(MyAppContextDb db)
        {
            _db = db;
        }
        public IActionResult Index()

        {
            List<Categorie> categories = _db.Categories.ToList();
            return View(categories);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Categorie categorie)

        {
            _db.Categories.Add(categorie);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
