using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GerenciadorAlimentacao.Models;

namespace GerenciadorAlimentacao.Controllers
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

            var sonoModel = await _context.Sono
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sonoModel == null)
            {
                return NotFound();
            }

            return View(sonoModel);
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
        public async Task<IActionResult> Create([Bind("Id,HorarioInicio,HorarioFim")] SonoModel sonoModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sonoModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sonoModel);
        }

        // GET: Sonos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Sono == null)
            {
                return NotFound();
            }

            var sonoModel = await _context.Sono.FindAsync(id);
            if (sonoModel == null)
            {
                return NotFound();
            }
            return View(sonoModel);
        }

        // POST: Sonos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,HorarioInicio,HorarioFim")] SonoModel sonoModel)
        {
            if (id != sonoModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sonoModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SonoModelExists(sonoModel.Id))
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
            return View(sonoModel);
        }

        // GET: Sonos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Sono == null)
            {
                return NotFound();
            }

            var sonoModel = await _context.Sono
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sonoModel == null)
            {
                return NotFound();
            }

            return View(sonoModel);
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
            var sonoModel = await _context.Sono.FindAsync(id);
            if (sonoModel != null)
            {
                _context.Sono.Remove(sonoModel);
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
