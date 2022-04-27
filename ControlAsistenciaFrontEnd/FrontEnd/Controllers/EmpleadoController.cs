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
    public class EmpleadoController : Controller
    {
        private readonly IEmpleadoServices empeladoService;
        private readonly ISedeServices sedeService;

        public EmpleadoController(ISedeServices _sedeServices, IEmpleadoServices _empleadoService)
        {
            sedeService = _sedeServices;
            empeladoService = _empleadoService;
        }

        // GET: Empleados
        public async Task<IActionResult> Index()
        {
            return View(await empeladoService.GetAllAsync());
        }

        // GET: Empleados/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empleado = await empeladoService.GetOneByIdAsync((int)id);
            if (empleado == null)
            {
                return NotFound();
            }

            return View(empleado);
        }

        // GET: Empleados/Create
        public IActionResult Create()
        {
            ViewData["IdSede"] = new SelectList(sedeService.GetAll(), "IdSede", "Sede1");
            return View();
        }

        // POST: Empleados/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdEmpleado,Nombre,PrimerApellido,SegundoApellido,Telefono,Correo,CantVacaciones,IdSede")] Empleado empleado)
        {
            if (ModelState.IsValid)
            {
                empeladoService.Insert(empleado);
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdSede"] = new SelectList(sedeService.GetAll(), "IdSede", "Sede1", empleado.IdSede);
            return View(empleado);
        }

        // GET: Empleados/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empleado = await empeladoService.GetOneByIdAsync((int)id);
            if (empleado == null)
            {
                return NotFound();
            }
            ViewData["IdSede"] = new SelectList(sedeService.GetAll(), "IdSede", "Sede1", empleado.IdSede);
            return View(empleado);
        }

        // POST: Empleados/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdEmpleado,Nombre,PrimerApellido,SegundoApellido,Telefono,Correo,CantVacaciones,IdSede")] Empleado empleado)
        {
            if (id != empleado.IdEmpleado)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    empeladoService.Update(empleado);
                }
                catch (Exception ee)
                {
                    if (!EmpleadoExists(empleado.IdEmpleado))
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
            ViewData["IdSede"] = new SelectList(sedeService.GetAll(), "IdSede", "Sede1", empleado.IdSede);
            return View(empleado);
        }

        // GET: Empleados/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empleado = await empeladoService.GetOneByIdAsync((int)id);
            if (empleado == null)
            {
                return NotFound();
            }


            return View(empleado);
        }

        // POST: Empleados/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var empleado = await empeladoService.GetOneByIdAsync((int)id);
            empeladoService.Delete(empleado);
            return RedirectToAction(nameof(Index));
        }

        private bool EmpleadoExists(int id)
        {
            return (empeladoService.GetOneByIdAsync((int)id) != null);
        }
    }
}
