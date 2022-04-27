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
    public class BitacotaAccionController : Controller
    {
        private readonly IBitacotaAccionServices bitacotaAccionService;
        private readonly IEmpleadoServices empleadoService;

        public BitacotaAccionController(IBitacotaAccionServices _bitacotaAccionService, IEmpleadoServices _empleadoService)
        {
            bitacotaAccionService =  _bitacotaAccionService;
            empleadoService = _empleadoService;
        }

        // GET: BitacotaAccion
        public async Task<IActionResult> Index()
        {
            return View(await bitacotaAccionService.GetAllAsync());
        }

        // GET: BitacotaAccion/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bitacotaAccion = await bitacotaAccionService.GetOneByIdAsync((int)id);
            if (bitacotaAccion == null)
            {
                return NotFound();
            }

            return View(bitacotaAccion);
        }

        // GET: BitacotaAccion/Create
        public IActionResult Create()
        {
            ViewData["IdEmpleado"] = new SelectList(empleadoService.GetAll(), "IdEmpleado", "Nombre");
            return View();
        }

        // POST: BitacotaAccion/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdBitacotaAccion,IdEmpleado,Fecha,Hora,Accion")] BitacotaAccion bitacotaAccion)
        {
            if (ModelState.IsValid)
            {
                bitacotaAccionService.Insert(bitacotaAccion);
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdEmpleado"] = new SelectList(empleadoService.GetAll(), "IdEmpleado", "Nombre", bitacotaAccion.IdEmpleado);
            return View(bitacotaAccion);
        }

        // GET: BitacotaAccion/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bitacotaAccion = await bitacotaAccionService.GetOneByIdAsync((int)id);
            if (bitacotaAccion == null)
            {
                return NotFound();
            }
            ViewData["IdEmpleado"] = new SelectList(empleadoService.GetAll(), "IdEmpleado", "Nombre", bitacotaAccion.IdEmpleado);
            return View(bitacotaAccion);
        }

        // POST: BitacotaAccion/Edit/5
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
                    bitacotaAccionService.Update(bitacotaAccion);
                }
                catch (Exception ee)
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
            ViewData["IdEmpleado"] = new SelectList(empleadoService.GetAll(), "IdEmpleado", "Nombre", bitacotaAccion.IdEmpleado);
            return View(bitacotaAccion);
        }

        // GET: BitacotaAccion/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bitacotaAccion = await bitacotaAccionService.GetOneByIdAsync((int)id);
            if (bitacotaAccion == null)
            {
                return NotFound();
            }

            return View(bitacotaAccion);
        }

        // POST: BitacotaAccion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bitacotaAccion = await bitacotaAccionService.GetOneByIdAsync((int)id);
            bitacotaAccionService.Delete(bitacotaAccion);
            return RedirectToAction(nameof(Index));
        }

        private bool BitacotaAccionExists(int id)
        {
            return (bitacotaAccionService.GetOneByIdAsync((int)id) != null);
        }
    }
}
