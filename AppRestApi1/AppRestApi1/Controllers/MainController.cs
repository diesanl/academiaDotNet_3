using Microsoft.AspNetCore.Mvc;

namespace AppRestApi1.Controllers
{
    [ApiController]
    [Route("Api")]
    public class MainController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        [HttpGet("getNome")]
        public string getOwnerNome()
        {
            return "Diego";
        }

        [HttpGet("getIdade")]
        public int getOwnerIdade()
        {
            return 37;
        }


        [HttpGet("returnNome/{nome}")]
        public string returnNome([FromRoute] string nome)
        {
            return "O nome digitado é " + nome;
        }

        [HttpGet("returnIdade")]
        public int returnIdade(int idade)
        {
            return idade;
        }

        [HttpGet("returnNomeIdade")]
        public string returnNomeIdade(string nome, int idade)
        {
            string result = "";
            if (idade >= 18)
                result = " é maior de idade";
            result = " é menor de idade";

            return nome + result;
        }
    }
}
