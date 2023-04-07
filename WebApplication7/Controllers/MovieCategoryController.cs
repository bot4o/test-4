using Microsoft.AspNetCore.Mvc;
using System.Reflection.Emit;

namespace WebApplication7.Controllers
{
    public class MovieCategoryController : Controller//movie category
    {
        //нормалния контролер CategoryController.cs който е оригинялният зима инфо от ApplicationDbContext.cs
        //от Migrations и там има лист Category затуи се чудя как да ти няпрая отделен контролер за movies.
        //може да са пробваш да създадеш нов migration с друго име на листа 
        public IActionResult Index()
        {
            return View();
        }
    }
}
