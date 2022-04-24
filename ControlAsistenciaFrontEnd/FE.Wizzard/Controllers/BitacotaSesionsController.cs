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
    public class BitacotaSesionsController : Controller
    {
        private readonly Control_AsistenciaContext _context;

        public BitacotaSesionsController(Control_AsistenciaContext context)
        {
            _context = context;
        }

        // GET: BitacotaSesions
        public async Task<IActionResult> Index()
        {
            var control_AsistenciaContext = _context.BitacotaSesion.Include(b => b.IdEmpleadoNavigation);
            return View(await control_AsistenciaContext.ToListAsync());
        }

        // GET: BitacotaSesions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bitacotaSesion = await _context.BitacotaSesion
                .Include(b => b.IdEmpleadoNavigation)
                .FirstOrDefaultAsync(m => m.IdBitacotaSesion == id);
            if (bitacotaSesion == null)
            {
                return NotFound();
            }

            return View(bitacotaSesion);
        }

        // GET: BitacotaSesions/Create
        public IActionResult Create()
        {
            ViewData["IdEmpleado"] = new SelectList(_context.Empleado, "IdEmpleado", "Correo");
            return View();
        }

        // POST: BitacotaSesions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdBitacotaSesion,IdEmpleado,Fecha,Hora")] BitacotaSesion bitacotaSesion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bitacotaSesion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdEmpleado"] = new SelectList(_context.Empleado, "IdEmpleado", "Correo", bitacotaSesion.IdEmpleado);
            return View(bitacotaSesion);
        }

        // GET: BitacotaSesions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bitacotaSesion = await _context.BitacotaSesion.FindAsync(id);
            if (bitacotaSesion == null)
            {
                return NotFound();
            }
            ViewData["IdEmpleado"] = new SelectList(_context.Empleado, "IdEmpleado", "Correo", bitacotaSesion.IdEmpleado);
            return View(bitacotaSesion);
        }

        // POST: BitacotaSesions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdBitacotaSesion,IdEmpleado,Fecha,Hora")] BitacotaSesion bitacotaSesion)
        {
            if (id != bitacotaSesion.IdBitacotaSesion)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bitacotaSesion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BitacotaSesionExists(bitacotaSesion.IdBitacotaSesion))
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
            ViewData["IdEmpleado"] = new SelectList(_context.Empleado, "IdEmpleado", "Correo", bitacotaSesion.IdEmpleado);
            return View(bitacotaSesion);
        }

        // GET: BitacotaSesions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bitacotaSesion = await _context.BitacotaSesion
                .Include(b => b.IdEmpleadoNavigation)
                .FirstOrDefaultAsync(m => m.IdBitacotaSesion == id);
            if (bitacotaSesion == null)
            {
                return NotFound();
            }

            return View(bitacotaSesion);
        }

        // POST: BitacotaSesions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bitacotaSesion = await _context.BitacotaSesion.FindAsync(id);
            _context.BitacotaSesion.Remove(bitacotaSesion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BitacotaSesionExists(int id)
        {
            return _context.BitacotaSesion.Any(e => e.IdBitacotaSesion == id);
        }
    }
}
