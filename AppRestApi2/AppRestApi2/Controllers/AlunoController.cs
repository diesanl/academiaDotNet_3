using AppRestApi2.DataModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AppRestApi2.Controllers
{

    public class AlunoController : Controller
    {
        [HttpGet]
        [Route("getAlunos")]
        public async Task<IActionResult> getAlunosAsync(
            [FromServices] Context context)
        {
            var alunos = await context.Alunos
                .AsNoTracking()
                .ToListAsync();

            return alunos == null ? NotFound() : Ok(alunos);
        }

        [HttpGet]
        [Route("getAlunos/{id}")]
        public async Task<IActionResult> getByIdAsync(
            [FromServices] Context context,
            [FromRoute] int id)
        {
            var aluno = await context.Alunos
                .AsNoTracking()
                .FirstOrDefaultAsync(a => a.id == id);

            return aluno == null ? NotFound() : Ok(aluno);
        }

        [HttpPost]
        [Route("getAlunos")]
        public async Task<IActionResult> PostAlunoAsync(
            [FromServices] Context context,
            [FromBody] Aluno aluno)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                await context.Alunos.AddAsync(aluno);
                await context.AddRangeAsync();
                return Created("$getAlunos/{aluno.id}", aluno)
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
