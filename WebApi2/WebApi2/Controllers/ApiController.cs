using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi2.DataModels;

namespace WebApi2.Controllers
{
    public class ApiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [Route("pessoas")]
        public async Task<IActionResult> getAllAsync(
            [FromServices] Context context)
        {
            var pessoas = await context.Pessoas
                .AsNoTracking()//soh pode ser usado em consultas - altamente recomendado por questão de desempenho
                .ToListAsync();

            return pessoas == null ? NotFound() : Ok(pessoas);
        }

        [HttpGet]
        [Route("pessoas/{id}")]
        public async Task<IActionResult> getByIdAsync(
            [FromServices] Context context,
            [FromRoute] int id)
        {
            Pessoa pessoa = await context.Pessoas
                .AsNoTracking()//soh pode ser usado em consultas - altamente recomendado por questão de desempenho
                .FirstOrDefaultAsync(p => p.id == id);

            return pessoa == null ? NotFound() : Ok(pessoa);
        }

        [HttpPost]
        [Route("pessoas")]
        public async Task<IActionResult> PostAsync(
            [FromServices] Context context,
            [FromBody] Pessoa pessoa)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                await context.Pessoas.AddAsync(pessoa);
                await context.SaveChangesAsync();
                return Created("$pessoas/{pessoa.id}", pessoa);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("pessoas/{id}")]
        public async Task<IActionResult> PutAsync(
            [FromServices] Context context,
            [FromBody] Pessoa pessoa,
            [FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Model Inválida");
            }

            Pessoa? p = await context.Pessoas
                .FirstOrDefaultAsync(x => x.id == id);

            if (null == p)
            {
                return NotFound("Pessoa não encontrada!!!!");
            }

            try
            {
                p.nome = pessoa.nome;

                context.Pessoas.Update(p);
                await context.SaveChangesAsync();
                return Ok(p);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("pessoas/{id}")]
        public async Task<IActionResult> DeleteAsync(
            [FromServices] Context context,
            [FromRoute] int id)
        {
            Pessoa? p = await context.Pessoas.FirstOrDefaultAsync(x => x.id == id);

            if (null == p)
            {
                return BadRequest("Pessoa não encontrada!!!!");
            }

            try
            {
                context.Pessoas.Remove(p);
                await context.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
