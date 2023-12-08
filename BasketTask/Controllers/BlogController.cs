using Microsoft.AspNetCore.Mvc;

namespace BasketTask.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
