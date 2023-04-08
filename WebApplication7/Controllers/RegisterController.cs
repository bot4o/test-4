using Microsoft.AspNetCore.Mvc;

namespace WebApplication7.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
    }
}
