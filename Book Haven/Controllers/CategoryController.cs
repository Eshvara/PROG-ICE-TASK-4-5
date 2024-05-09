using Microsoft.AspNetCore.Mvc;

namespace Book_Haven.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
