using Microsoft.AspNetCore.Mvc;

namespace AppRestApi2.Controllers
{
    public class CursoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
