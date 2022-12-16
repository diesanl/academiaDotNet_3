using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GerenciadorEventos.Models;

namespace GerenciadorEventos.Controllers
{
    public class RefeicoesController : Controller
    {
        private readonly Context _context;

        public RefeicoesController(Context context)
        {
            _context = context;
        }

        // GET: Refeicoes
        public async Task<IActionResult> Index()
        {
            return _context.Refeicao != null ?
                        View(await _context.Refeicao.ToListAsync()) :
                        Problem("Entity set 'Context.Refeicao'  is null.");
        }

        // GET: Refeicoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Refeicao == null)
            {
                return NotFound();
            }

            var refeicaoModel = await _context.Refeicao
                .FirstOrDefaultAsync(m => m.Id == id);
            if (refeicaoModel == null)
            {
                return NotFound();
            }

            return View(refeicaoModel);
        }

        // GET: Refeicoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Refeicoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Descricao,Tipo,Hora, PessoaId")] int id, string descricao, string tipo, DateTime hora, int pessoaId)
        {

            //Console.WriteLine(id.ToString());
            //Console.WriteLine(descricao);
            //Console.WriteLine(tipo);
            //Console.WriteLine(hora);
            //Console.WriteLine(pessoaId.ToString());
            try
            {
                _context.Refeicao.Add(new RefeicaoModel
                {
                    Descricao = descricao,
                    Tipo = tipo,
                    Hora = hora,
                    PessoaId = pessoaId
                });
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return View();
        }

        // GET: Refeicoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Refeicao == null)
            {
                return NotFound();
            }

            var refeicaoModel = await _context.Refeicao.FindAsync(id);
            if (refeicaoModel == null)
            {
                return NotFound();
            }
            return View(refeicaoModel);
        }

        // POST: Refeicoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Descricao,Tipo,Hora")] RefeicaoModel refeicaoModel)
        {
            if (id != refeicaoModel.Id)
            {
                return NotFound();
            }

            try
            {
                var rModel = await _context.Refeicao
                .FirstOrDefaultAsync(m => m.Id == id);
                try
                {
                    Console.WriteLine(rModel.Id);
                    //rModel.Id = refeicaoModel.Id;
                    rModel.Descricao = refeicaoModel.Descricao;
                    rModel.Tipo = refeicaoModel.Tipo;
                    rModel.Hora = refeicaoModel.Hora;

                    _context.Refeicao.Update(rModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RefeicaoModelExists(refeicaoModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return View();
        }

        // GET: Refeicoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Refeicao == null)
            {
                return NotFound();
            }

            var refeicaoModel = await _context.Refeicao
                .FirstOrDefaultAsync(m => m.Id == id);
            if (refeicaoModel == null)
            {
                return NotFound();
            }

            return View(refeicaoModel);
        }

        // POST: Refeicoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Refeicao == null)
            {
                return Problem("Entity set 'Context.Refeicao'  is null.");
            }
            var refeicaoModel = await _context.Refeicao.FindAsync(id);
            if (refeicaoModel != null)
            {
                _context.Refeicao.Remove(refeicaoModel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RefeicaoModelExists(int id)
        {
            return (_context.Refeicao?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
