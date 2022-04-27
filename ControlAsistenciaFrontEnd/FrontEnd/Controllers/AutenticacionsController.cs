using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FrontEnd.Models;

namespace FE.Wizzard.Controllers
{
    public class AutenticacionsController : Controller
    {
        private readonly Control_AsistenciaContext _context;

        public AutenticacionsController(Control_AsistenciaContext context)
        {
            _context = context;
        }

        // GET: Autenticacions
        public async Task<IActionResult> Index()
        {
            var control_AsistenciaContext = _context.Autenticacion.Include(a => a.IdEmpleadoNavigation).Include(a => a.IdRolNavigation);
            return View(await control_AsistenciaContext.ToListAsync());
        }

        // GET: Autenticacions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var autenticacion = await _context.Autenticacion
                .Include(a => a.IdEmpleadoNavigation)
                .Include(a => a.IdRolNavigation)
                .FirstOrDefaultAsync(m => m.IdAutenticacion == id);
            if (autenticacion == null)
            {
                return NotFound();
            }

            return View(autenticacion);
        }

        // GET: Autenticacions/Create
        public IActionResult Create()
        {
            ViewData["IdEmpleado"] = new SelectList(_context.Empleado, "IdEmpleado", "Correo");
            ViewData["IdRol"] = new SelectList(_context.Rol, "IdRol", "Rol1");
            return View();
        }

        // POST: Autenticacions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdAutenticacion,Usuario,Contrasena,Estado,IdEmpleado,IdRol")] Autenticacion autenticacion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(autenticacion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdEmpleado"] = new SelectList(_context.Empleado, "IdEmpleado", "Correo", autenticacion.IdEmpleado);
            ViewData["IdRol"] = new SelectList(_context.Rol, "IdRol", "Rol1", autenticacion.IdRol);
            return View(autenticacion);
        }

        // GET: Autenticacions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var autenticacion = await _context.Autenticacion.FindAsync(id);
            if (autenticacion == null)
            {
                return NotFound();
            }
            ViewData["IdEmpleado"] = new SelectList(_context.Empleado, "IdEmpleado", "Correo", autenticacion.IdEmpleado);
            ViewData["IdRol"] = new SelectList(_context.Rol, "IdRol", "Rol1", autenticacion.IdRol);
            return View(autenticacion);
        }

        // POST: Autenticacions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdAutenticacion,Usuario,Contrasena,Estado,IdEmpleado,IdRol")] Autenticacion autenticacion)
        {
            if (id != autenticacion.IdAutenticacion)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(autenticacion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AutenticacionExists(autenticacion.IdAutenticacion))
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
            ViewData["IdEmpleado"] = new SelectList(_context.Empleado, "IdEmpleado", "Correo", autenticacion.IdEmpleado);
            ViewData["IdRol"] = new SelectList(_context.Rol, "IdRol", "Rol1", autenticacion.IdRol);
            return View(autenticacion);
        }

        // GET: Autenticacions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var autenticacion = await _context.Autenticacion
                .Include(a => a.IdEmpleadoNavigation)
                .Include(a => a.IdRolNavigation)
                .FirstOrDefaultAsync(m => m.IdAutenticacion == id);
            if (autenticacion == null)
            {
                return NotFound();
            }

            return View(autenticacion);
        }

        // POST: Autenticacions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var autenticacion = await _context.Autenticacion.FindAsync(id);
            _context.Autenticacion.Remove(autenticacion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AutenticacionExists(int id)
        {
            return _context.Autenticacion.Any(e => e.IdAutenticacion == id);
        }
    }
}
