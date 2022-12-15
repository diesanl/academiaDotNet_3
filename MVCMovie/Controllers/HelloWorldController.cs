using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MVCMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //public string Index()
        //{
        //    return "Minha ação padrão";
        //}

        //public string Welcome()
        //{
        //    return "Bem vindo ap meu método de boas vindas do meu controller";
        //}

        //public string Welcome(string nome, int vezes)
        //{
        //    return HtmlEncoder.Default.Encode($"Oi {nome}, vezes: {vezes}");
        //}

        public IActionResult Welcome(string nome, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + nome;
            ViewData["NumTimes"] = numTimes;

            return View();

        }

        public double Soma(int a, int b)
        {
            return a + b;
        }
    }
}
