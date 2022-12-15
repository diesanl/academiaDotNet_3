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
    public class SonosController : Controller
    {
        private readonly Context _context;

        public SonosController(Context context)
        {
            _context = context;
        }

        // GET: Sonos
        public async Task<IActionResult> Index()
        {
            return _context.Sono != null ?
                        View(await _context.Sono.ToListAsync()) :
                        Problem("Entity set 'Context.Sono'  is null.");
        }

        // GET: Sonos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Sono == null)
            {
                return NotFound();
            }

            var SonoModel = await _context.Sono
                .FirstOrDefaultAsync(m => m.Id == id);
            if (SonoModel == null)
            {
                return NotFound();
            }

            return View(SonoModel);
        }

        // GET: Sonos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sonos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,HorarioInicio,HorarioFim")] SonoModel SonoModel)
        {

            try
            {
                _context.Sono.Add(SonoModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return View();
        }

        // GET: Sonos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Sono == null)
            {
                return NotFound();
            }

            var SonoModel = await _context.Sono.FindAsync(id);
            if (SonoModel == null)
            {
                return NotFound();
            }
            return View(SonoModel);
        }

        // POST: Sonos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,HorarioInicio,HorarioFim")] SonoModel SonoModel)
        {
            if (id != SonoModel.Id)
            {
                return NotFound();
            }

            try
            {
                try
                {
                    _context.Sono.Update(SonoModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SonoModelExists(SonoModel.Id))
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

        // GET: Sonos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Sono == null)
            {
                return NotFound();
            }

            var SonoModel = await _context.Sono
                .FirstOrDefaultAsync(m => m.Id == id);
            if (SonoModel == null)
            {
                return NotFound();
            }

            return View(SonoModel);
        }

        // POST: Sonos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Sono == null)
            {
                return Problem("Entity set 'Context.Sono'  is null.");
            }
            var SonoModel = await _context.Sono.FindAsync(id);
            if (SonoModel != null)
            {
                _context.Sono.Remove(SonoModel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SonoModelExists(int id)
        {
            return (_context.Sono?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
