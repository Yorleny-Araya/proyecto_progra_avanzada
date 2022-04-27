using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FrontEnd.Models;
using FrontEnd.Servicios;


namespace FrontdEnd.Controllers
{
    public class AsistenciasController : Controller
    {
        private readonly IEmpleadoServices empeladoService;
        private readonly ITipoAsistenciaServices tipoAsistenciaService;
        private readonly IAsistenciaServices asistenciaService;

        public AsistenciasController(ITipoAsistenciaServices _tipoAsistenciaService, IEmpleadoServices _empleadoService, IAsistenciaServices _asistenciaService)
        {
            tipoAsistenciaService = _tipoAsistenciaService;
            empeladoService = _empleadoService;
            asistenciaService = _asistenciaService;
        }

        // GET: Asistencias
        public async Task<IActionResult> Index()
        {

            return View(await asistenciaService.GetAllAsync());
        }

        // GET: Asistencias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var asistencia = await asistenciaService.GetOneByIdAsync((int)id);
            if (asistencia == null)
            {
                return NotFound();
            }

            return View(asistencia);
        }

        // GET: Asistencias/Create
        public IActionResult Create()
        {
            ViewData["IdEmpleado"] = new SelectList(empeladoService.GetAll(), "IdEmpleado", "Nombre");
            ViewData["IdTipoAsistencia"] = new SelectList(tipoAsistenciaService.GetAll(), "IdTipoAsistencia", "TipoAsistencia1");
            return View();
        }

        // POST: Asistencias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdAsistencia,IdEmpleado,Fecha,Hora,IdTipoAsistencia")] Asistencia asistencia)
        {
            if (ModelState.IsValid)
            {
                asistenciaService.Insert(asistencia);
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdEmpleado"] = new SelectList(empeladoService.GetAll(), "IdEmpleado", "Nombre");
            ViewData["IdTipoAsistencia"] = new SelectList(tipoAsistenciaService.GetAll(), "IdTipoAsistencia", "TipoAsistencia1");
            return View(asistencia);
        }

        // GET: Asistencias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var asistencia = await asistenciaService.GetOneByIdAsync((int)id);
            if (asistencia == null)
            {
                return NotFound();
            }
            ViewData["IdEmpleado"] = new SelectList(empeladoService.GetAll(), "IdEmpleado", "Nombre");
            ViewData["IdTipoAsistencia"] = new SelectList(tipoAsistenciaService.GetAll(), "IdTipoAsistencia", "TipoAsistencia1");
            return View(asistencia);
        }

        // POST: Asistencias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdAsistencia,IdEmpleado,Fecha,Hora,IdTipoAsistencia")] Asistencia asistencia)
        {
            if (id != asistencia.IdEmpleado)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    asistenciaService.Update(asistencia);
                }
                catch (Exception ee)
                {
                    if (!AsistenciaExists(asistencia.IdEmpleado))
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
            ViewData["IdEmpleado"] = new SelectList(empeladoService.GetAll(), "IdEmpleado", "Nombre");
            ViewData["IdTipoAsistencia"] = new SelectList(tipoAsistenciaService.GetAll(), "IdTipoAsistencia", "TipoAsistencia1");
            return View(asistencia);
        }

        // GET: Asistencias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var asistencia = await asistenciaService.GetOneByIdAsync((int)id);
            if (asistencia == null)
            {
                return NotFound();
            }


            return View(asistencia);
        }

        // POST: Asistencias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var asistencia = await asistenciaService.GetOneByIdAsync((int)id);
            asistenciaService.Delete(asistencia);
            return RedirectToAction(nameof(Index));
        }

        private bool AsistenciaExists(int id)
        {
            return (asistenciaService.GetOneByIdAsync((int)id) != null);
        }
    }
}
