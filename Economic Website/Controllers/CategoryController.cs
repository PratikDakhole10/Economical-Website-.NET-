using Microsoft.AspNetCore.Mvc;

namespace Economic_Website.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
