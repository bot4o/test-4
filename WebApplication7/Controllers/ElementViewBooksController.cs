using Microsoft.AspNetCore.Mvc;

namespace WebApplication7.Controllers
{
    public class ElementViewBooksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
