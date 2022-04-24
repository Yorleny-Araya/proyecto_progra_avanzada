using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FE.Wizzard.Models;

namespace FE.Wizzard.Controllers
{
    public class TipoAusenciasController : Controller
    {
        private readonly Control_AsistenciaContext _context;

        public TipoAusenciasController(Control_AsistenciaContext context)
        {
            _context = context;
        }

        // GET: TipoAusencias
        public async Task<IActionResult> Index()
        {
            return View(await _context.TipoAusencia.ToListAsync());
        }

        // GET: TipoAusencias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoAusencia = await _context.TipoAusencia
                .FirstOrDefaultAsync(m => m.IdTipoAusencia == id);
            if (tipoAusencia == null)
            {
                return NotFound();
            }

            return View(tipoAusencia);
        }

        // GET: TipoAusencias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TipoAusencias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdTipoAusencia,TipoAusencia1")] TipoAusencia tipoAusencia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoAusencia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoAusencia);
        }

        // GET: TipoAusencias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoAusencia = await _context.TipoAusencia.FindAsync(id);
            if (tipoAusencia == null)
            {
                return NotFound();
            }
            return View(tipoAusencia);
        }

        // POST: TipoAusencias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdTipoAusencia,TipoAusencia1")] TipoAusencia tipoAusencia)
        {
            if (id != tipoAusencia.IdTipoAusencia)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoAusencia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoAusenciaExists(tipoAusencia.IdTipoAusencia))
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
            return View(tipoAusencia);
        }

        // GET: TipoAusencias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoAusencia = await _context.TipoAusencia
                .FirstOrDefaultAsync(m => m.IdTipoAusencia == id);
            if (tipoAusencia == null)
            {
                return NotFound();
            }

            return View(tipoAusencia);
        }

        // POST: TipoAusencias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tipoAusencia = await _context.TipoAusencia.FindAsync(id);
            _context.TipoAusencia.Remove(tipoAusencia);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoAusenciaExists(int id)
        {
            return _context.TipoAusencia.Any(e => e.IdTipoAusencia == id);
        }
    }
}
