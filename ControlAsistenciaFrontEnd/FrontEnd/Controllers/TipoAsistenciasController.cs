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
    public class TipoAsistenciasController : Controller
    {
        private readonly ITipoAsistenciaServices tipoAsistenciaServices;

        public TipoAsistenciasController(ITipoAsistenciaServices _tipoAsistenciaServices)
        {
            tipoAsistenciaServices = _tipoAsistenciaServices;
        }

        // GET: TipoAsistencia
        public async Task<IActionResult> Index()
        {
            return View(tipoAsistenciaServices.GetAll());
        }

        // GET: TipoAsistencia/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoAsistencia = tipoAsistenciaServices.GetOneById((int)id);
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

        // POST: TipoAsistencia/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdTipoAsistencia,TipoAsistencia1")] TipoAsistencia tipoAsistencia)
        {
            if (ModelState.IsValid)
            {
                tipoAsistenciaServices.Insert(tipoAsistencia);
                return RedirectToAction(nameof(Index));
            }
            return View(tipoAsistencia); ;
        }

        // GET: TipoAsistencia/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoAsistencia = tipoAsistenciaServices.GetOneById((int)id);
            if (tipoAsistencia == null)
            {
                return NotFound();
            }
            return View(tipoAsistencia);
        }

        // POST: TipoAsistencia/Edit/5
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
                    tipoAsistenciaServices.Update(tipoAsistencia);
                }
                catch (Exception ee)
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

            var tipoAsistencia = tipoAsistenciaServices.GetOneById((int)id);
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
            var tipoAusencia = tipoAsistenciaServices.GetOneById((int)id);
            tipoAsistenciaServices.Delete(tipoAusencia);
            return RedirectToAction(nameof(Index));
        }

        private bool TipoAsistenciaExists(int id)
        {
  return (tipoAsistenciaServices.GetOneById((int)id) != null);
        }
    }
}
