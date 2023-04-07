using Microsoft.AspNetCore.Mvc;

namespace WebApplication7.Controllers
{
    public class ElementViewMoviesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
