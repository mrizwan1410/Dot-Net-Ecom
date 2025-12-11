using Dot_Net_Ecom.Data;
using Dot_Net_Ecom.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dot_Net_Ecom.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Category> objCategoryList = _db.Categories.ToList();
            return View(objCategoryList);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
