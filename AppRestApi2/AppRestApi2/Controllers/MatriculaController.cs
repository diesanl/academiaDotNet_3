using Microsoft.AspNetCore.Mvc;

namespace AppRestApi2.Controllers
{
    public class MatriculaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
