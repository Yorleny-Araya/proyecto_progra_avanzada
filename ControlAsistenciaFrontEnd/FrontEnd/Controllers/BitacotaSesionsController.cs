using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FrontEnd.Models;

using FrontEnd.Servicios;

namespace FrontEnd.Controllers
{
    public class BitacotaSesionsController : Controller
    {
        private readonly IBitacotaSesionServices bitacotaSesionService;
        private readonly IEmpleadoServices empleadoService;

        public BitacotaSesionsController(IBitacotaSesionServices _bitacotaAccionService, IEmpleadoServices _empleadoService)
        {
            bitacotaSesionService = _bitacotaAccionService;
            empleadoService = _empleadoService;
        }

        // GET: BitacotaSesions
        public async Task<IActionResult> Index()
        {
            return View(await bitacotaSesionService.GetAllAsync());
        }

        // GET: BitacotaSesions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bitacotaSesion = await bitacotaSesionService.GetOneByIdAsync((int)id);
            if (bitacotaSesion == null)
            {
                return NotFound();
            }

            return View(bitacotaSesion);
        }

        // GET: BitacotaSesions/Create
        public IActionResult Create()
        {
            ViewData["IdEmpleado"] = new SelectList(empleadoService.GetAll(), "IdEmpleado", "Nombre");
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
                bitacotaSesionService.Insert(bitacotaSesion);
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdEmpleado"] = new SelectList(empleadoService.GetAll(), "IdEmpleado", "Nombre", bitacotaSesion.IdEmpleado);
            return View(bitacotaSesion);
        }

        // GET: BitacotaSesions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bitacotaSesion = await bitacotaSesionService.GetOneByIdAsync((int)id);
            if (bitacotaSesion == null)
            {
                return NotFound();
            }
            ViewData["IdEmpleado"] = new SelectList(empleadoService.GetAll(), "IdEmpleado", "Nombre", bitacotaSesion.IdEmpleado);
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
                    bitacotaSesionService.Update(bitacotaSesion);
                }
                catch (Exception ee)
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
                ViewData["IdEmpleado"] = new SelectList(empleadoService.GetAll(), "IdEmpleado", "Nombre", bitacotaSesion.IdEmpleado);
                return View(bitacotaSesion);
        }
        

        // GET: BitacotaSesions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
                if (id == null)
                {
                    return NotFound();
                }

                var bitacotaSesion = await bitacotaSesionService.GetOneByIdAsync((int)id);
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
            var bitacotaSesion = await bitacotaSesionService.GetOneByIdAsync((int)id);
            bitacotaSesionService.Delete(bitacotaSesion);
            return RedirectToAction(nameof(Index));
        }

        private bool BitacotaSesionExists(int id)
        {
            return (bitacotaSesionService.GetOneByIdAsync((int)id) != null);
        }
    }
}
