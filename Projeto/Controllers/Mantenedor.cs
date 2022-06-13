using Microsoft.AspNetCore.Mvc;

namespace Projeto.Controllers
{
    public class Mantenedor : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
