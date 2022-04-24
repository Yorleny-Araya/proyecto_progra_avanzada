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
    public class AusenciasController : Controller
    {
        private readonly Control_AsistenciaContext _context;

        public AusenciasController(Control_AsistenciaContext context)
        {
            _context = context;
        }

        // GET: Ausencias
        public async Task<IActionResult> Index()
        {
            var control_AsistenciaContext = _context.Ausencia.Include(a => a.IdEmpleadoNavigation).Include(a => a.IdTipoAusenciaNavigation);
            return View(await control_AsistenciaContext.ToListAsync());
        }

        // GET: Ausencias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ausencia = await _context.Ausencia
                .Include(a => a.IdEmpleadoNavigation)
                .Include(a => a.IdTipoAusenciaNavigation)
                .FirstOrDefaultAsync(m => m.IdAusencia == id);
            if (ausencia == null)
            {
                return NotFound();
            }

            return View(ausencia);
        }

        // GET: Ausencias/Create
        public IActionResult Create()
        {
            ViewData["IdEmpleado"] = new SelectList(_context.Empleado, "IdEmpleado", "Correo");
            ViewData["IdTipoAusencia"] = new SelectList(_context.TipoAusencia, "IdTipoAusencia", "TipoAusencia1");
            return View();
        }

        // POST: Ausencias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdAusencia,IdEmpleado,FechaInicio,FechaFinal,CantDias,Motivo,IdTipoAusencia")] Ausencia ausencia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ausencia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdEmpleado"] = new SelectList(_context.Empleado, "IdEmpleado", "Correo", ausencia.IdEmpleado);
            ViewData["IdTipoAusencia"] = new SelectList(_context.TipoAusencia, "IdTipoAusencia", "TipoAusencia1", ausencia.IdTipoAusencia);
            return View(ausencia);
        }

        // GET: Ausencias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ausencia = await _context.Ausencia.FindAsync(id);
            if (ausencia == null)
            {
                return NotFound();
            }
            ViewData["IdEmpleado"] = new SelectList(_context.Empleado, "IdEmpleado", "Correo", ausencia.IdEmpleado);
            ViewData["IdTipoAusencia"] = new SelectList(_context.TipoAusencia, "IdTipoAusencia", "TipoAusencia1", ausencia.IdTipoAusencia);
            return View(ausencia);
        }

        // POST: Ausencias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdAusencia,IdEmpleado,FechaInicio,FechaFinal,CantDias,Motivo,IdTipoAusencia")] Ausencia ausencia)
        {
            if (id != ausencia.IdAusencia)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ausencia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AusenciaExists(ausencia.IdAusencia))
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
            ViewData["IdEmpleado"] = new SelectList(_context.Empleado, "IdEmpleado", "Correo", ausencia.IdEmpleado);
            ViewData["IdTipoAusencia"] = new SelectList(_context.TipoAusencia, "IdTipoAusencia", "TipoAusencia1", ausencia.IdTipoAusencia);
            return View(ausencia);
        }

        // GET: Ausencias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ausencia = await _context.Ausencia
                .Include(a => a.IdEmpleadoNavigation)
                .Include(a => a.IdTipoAusenciaNavigation)
                .FirstOrDefaultAsync(m => m.IdAusencia == id);
            if (ausencia == null)
            {
                return NotFound();
            }

            return View(ausencia);
        }

        // POST: Ausencias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ausencia = await _context.Ausencia.FindAsync(id);
            _context.Ausencia.Remove(ausencia);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AusenciaExists(int id)
        {
            return _context.Ausencia.Any(e => e.IdAusencia == id);
        }
    }
}
