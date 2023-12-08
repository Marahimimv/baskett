using Microsoft.AspNetCore.Mvc;

namespace BasketTask.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
