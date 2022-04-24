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
    public class TipoAsistenciasController : Controller
    {
        private readonly Control_AsistenciaContext _context;

        public TipoAsistenciasController(Control_AsistenciaContext context)
        {
            _context = context;
        }

        // GET: TipoAsistencias
        public async Task<IActionResult> Index()
        {
            return View(await _context.TipoAsistencia.ToListAsync());
        }

        // GET: TipoAsistencias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoAsistencia = await _context.TipoAsistencia
                .FirstOrDefaultAsync(m => m.IdTipoAsistencia == id);
            if (tipoAsistencia == null)
            {
                return NotFound();
            }

            return View(tipoAsistencia);
        }

        // GET: TipoAsistencias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TipoAsistencias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdTipoAsistencia,TipoAsistencia1")] TipoAsistencia tipoAsistencia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoAsistencia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoAsistencia);
        }

        // GET: TipoAsistencias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoAsistencia = await _context.TipoAsistencia.FindAsync(id);
            if (tipoAsistencia == null)
            {
                return NotFound();
            }
            return View(tipoAsistencia);
        }

        // POST: TipoAsistencias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdTipoAsistencia,TipoAsistencia1")] TipoAsistencia tipoAsistencia)
        {
            if (id != tipoAsistencia.IdTipoAsistencia)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoAsistencia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoAsistenciaExists(tipoAsistencia.IdTipoAsistencia))
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
            return View(tipoAsistencia);
        }

        // GET: TipoAsistencias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoAsistencia = await _context.TipoAsistencia
                .FirstOrDefaultAsync(m => m.IdTipoAsistencia == id);
            if (tipoAsistencia == null)
            {
                return NotFound();
            }

            return View(tipoAsistencia);
        }

        // POST: TipoAsistencias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tipoAsistencia = await _context.TipoAsistencia.FindAsync(id);
            _context.TipoAsistencia.Remove(tipoAsistencia);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoAsistenciaExists(int id)
        {
            return _context.TipoAsistencia.Any(e => e.IdTipoAsistencia == id);
        }
    }
}
