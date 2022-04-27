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
    public class TipoAusenciaController : Controller
    {
        private readonly ITipoAusenciaServices tipoAusenciasServices;

        public TipoAusenciaController(ITipoAusenciaServices TipoAusencias)
        {
            tipoAusenciasServices = TipoAusencias;
        }

        // GET: TipoAusencia
        public async Task<IActionResult> Index()
        {
            return View(tipoAusenciasServices.GetAll());
        }

        // GET: TipoAusencia/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoAusencia = tipoAusenciasServices.GetOneById((int)id);
            if (tipoAusencia == null)
            {
                return NotFound();
            }

            return View(tipoAusencia);
        }

        // GET: TipoAusencia/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TipoAusencia/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdTipoAusencia,TipoAusencia1")] TipoAusencia tipoAusencia)
        {
            if (ModelState.IsValid)
            {
                tipoAusenciasServices.Insert(tipoAusencia);
                return RedirectToAction(nameof(Index));
            }
            return View(tipoAusencia); ;
        }

        // GET: TipoAusencia/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoAusencia = tipoAusenciasServices.GetOneById((int)id);
            if (tipoAusencia == null)
            {
                return NotFound();
            }
            return View(tipoAusencia);
        }

        // POST: TipoAusencia/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdTipoAusencia,TipoAusencia1")] TipoAusencia tipoAusencia)
        {
            if (id != tipoAusencia.IdTipoAusencia)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    tipoAusenciasServices.Update(tipoAusencia);
                }
                catch (Exception ee)
                {
                    if (!TipoAusenciaExists(tipoAusencia.IdTipoAusencia))
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
            return View(tipoAusencia);
        }

        // GET: TipoAusencia/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoAusencia = tipoAusenciasServices.GetOneById((int)id);
            if (tipoAusencia == null)
            {
                return NotFound();
            }

            return View(tipoAusencia);
        }

        // POST: TipoAusencia/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tipoAusencia = tipoAusenciasServices.GetOneById((int)id);
            tipoAusenciasServices.Delete(tipoAusencia);
            return RedirectToAction(nameof(Index));
        }

        private bool TipoAusenciaExists(int id)
        {
            return (tipoAusenciasServices.GetOneById((int)id) != null);
        }
    }
}
