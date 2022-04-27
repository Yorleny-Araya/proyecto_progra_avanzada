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
    public class AusenciasController : Controller
    {
        private readonly IEmpleadoServices empeladoService;
        private readonly ITipoAusenciaServices tipoAusenciaService;
        private readonly IAusenciaServices ausenciaService;

        public AusenciasController(ITipoAusenciaServices _tipoAusenciaService, IEmpleadoServices _empleadoService, IAusenciaServices _ausenciaService)
        {
            tipoAusenciaService = _tipoAusenciaService;
            empeladoService = _empleadoService;
            ausenciaService = _ausenciaService;
        }

        // GET: Ausencias
        public async Task<IActionResult> Index()
        
            {
                return View(await ausenciaService.GetAllAsync());
            }

        // GET: Ausencias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ausencia = await ausenciaService.GetOneByIdAsync((int)id);
            if (ausencia == null)
            {
                return NotFound();
            }

            return View(ausencia);
        }

    

    // GET: Ausencias/Create
    public IActionResult Create()
        {
            ViewData["IdEmpleado"] = new SelectList(empeladoService.GetAll(), "IdEmpleado", "Nombre");
            ViewData["IdTipoAusencia"] = new SelectList(tipoAusenciaService.GetAll(),"IdTipoAusencia", "TipoAusencia1");
            return View();
        }

        // POST: Ausencias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( [Bind("IdAusencia,IdEmpleado,FechaInicio,FechaFinal,CantDias,Motivo,IdTipoAusencia")] Ausencia ausencia)
        {
            if (ModelState.IsValid)
            {
                ausenciaService.Insert(ausencia);
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdEmpleado"] = new SelectList(empeladoService.GetAll(), "IdEmpleado", "Nombre");
            ViewData["IdTipoAusencia"] = new SelectList(tipoAusenciaService.GetAll(), "IdTipoAusencia", "TipoAusencia1");
            return View(ausencia);
        }

        // GET: Ausencias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ausencia = await ausenciaService.GetOneByIdAsync((int)id);
            if (ausencia == null)
            {
                return NotFound();
            }
            ViewData["IdEmpleado"] = new SelectList(empeladoService.GetAll(), "IdEmpleado", "Nombre");
            ViewData["IdTipoAusencia"] = new SelectList(tipoAusenciaService.GetAll(), "IdTipoAusencia", "TipoAusencia1");
            return View(ausencia);
        }

        // POST: Ausencias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdAusencia,IdEmpleado,FechaInicio,FechaFinal,CantDias,Motivo,IdTipoAusencia")] Ausencia ausencia)
        {
            if (id != ausencia.IdEmpleado)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    ausenciaService.Update(ausencia);
                }
                catch (Exception ee)
                {
                    if (!AusenciaExists(ausencia.IdEmpleado))
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
            ViewData["IdTipoAusencia"] = new SelectList(tipoAusenciaService.GetAll(), "IdTipoAusencia", "TipoAusencia1");
            return View(ausencia);
        }

        // GET: Ausencias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ausencia = await ausenciaService.GetOneByIdAsync((int)id);
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
            var ausencia = await ausenciaService.GetOneByIdAsync((int)id);
            ausenciaService.Delete(ausencia);
            return RedirectToAction(nameof(Index));
        }

        private bool AusenciaExists(int id)
        {
            return (ausenciaService.GetOneByIdAsync((int)id) != null);
        }
    }
}
