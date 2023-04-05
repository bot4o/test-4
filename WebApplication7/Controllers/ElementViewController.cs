using Microsoft.AspNetCore.Mvc;

namespace WebApplication7.Controllers
{
    public class ElementViewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
