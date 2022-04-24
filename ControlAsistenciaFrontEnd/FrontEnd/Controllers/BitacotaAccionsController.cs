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
    public class BitacotaAccionsController : Controller
    {
        private readonly Control_AsistenciaContext _context;

        public BitacotaAccionsController(Control_AsistenciaContext context)
        {
            _context = context;
        }

        // GET: BitacotaAccions
        public async Task<IActionResult> Index()
        {
            var control_AsistenciaContext = _context.BitacotaAccion.Include(b => b.IdEmpleadoNavigation);
            return View(await control_AsistenciaContext.ToListAsync());
        }

        // GET: BitacotaAccions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bitacotaAccion = await _context.BitacotaAccion
                .Include(b => b.IdEmpleadoNavigation)
                .FirstOrDefaultAsync(m => m.IdBitacotaAccion == id);
            if (bitacotaAccion == null)
            {
                return NotFound();
            }

            return View(bitacotaAccion);
        }

        // GET: BitacotaAccions/Create
        public IActionResult Create()
        {
            ViewData["IdEmpleado"] = new SelectList(_context.Empleado, "IdEmpleado", "Correo");
            return View();
        }

        // POST: BitacotaAccions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdBitacotaAccion,IdEmpleado,Fecha,Hora,Accion")] BitacotaAccion bitacotaAccion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bitacotaAccion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdEmpleado"] = new SelectList(_context.Empleado, "IdEmpleado", "Correo", bitacotaAccion.IdEmpleado);
            return View(bitacotaAccion);
        }

        // GET: BitacotaAccions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bitacotaAccion = await _context.BitacotaAccion.FindAsync(id);
            if (bitacotaAccion == null)
            {
                return NotFound();
            }
            ViewData["IdEmpleado"] = new SelectList(_context.Empleado, "IdEmpleado", "Correo", bitacotaAccion.IdEmpleado);
            return View(bitacotaAccion);
        }

        // POST: BitacotaAccions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdBitacotaAccion,IdEmpleado,Fecha,Hora,Accion")] BitacotaAccion bitacotaAccion)
        {
            if (id != bitacotaAccion.IdBitacotaAccion)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bitacotaAccion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BitacotaAccionExists(bitacotaAccion.IdBitacotaAccion))
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
            ViewData["IdEmpleado"] = new SelectList(_context.Empleado, "IdEmpleado", "Correo", bitacotaAccion.IdEmpleado);
            return View(bitacotaAccion);
        }

        // GET: BitacotaAccions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bitacotaAccion = await _context.BitacotaAccion
                .Include(b => b.IdEmpleadoNavigation)
                .FirstOrDefaultAsync(m => m.IdBitacotaAccion == id);
            if (bitacotaAccion == null)
            {
                return NotFound();
            }

            return View(bitacotaAccion);
        }

        // POST: BitacotaAccions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bitacotaAccion = await _context.BitacotaAccion.FindAsync(id);
            _context.BitacotaAccion.Remove(bitacotaAccion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BitacotaAccionExists(int id)
        {
            return _context.BitacotaAccion.Any(e => e.IdBitacotaAccion == id);
        }
    }
}
