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
    public class SedesController : Controller
    {
        private readonly ISedeServices sedeServices;

        public SedesController(ISedeServices _sedesServices)
        {
            sedeServices = _sedesServices;
        }

        // GET: Sedes
        public async Task<IActionResult> Index()
        {
            return View(sedeServices.GetAll());
        }

        // GET: Sedes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sede = sedeServices.GetOneById((int)id);
            if (sede == null)
            {
                return NotFound();
            }

            return View(sede);
        }

        // GET: Sedes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sedes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdSede,Sede1")] Sede sede)
        {
            if (ModelState.IsValid)
            {
                sedeServices.Insert(sede);
                return RedirectToAction(nameof(Index));
            }
            return View(sede); ;
        }

        // GET: Sedes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sede = sedeServices.GetOneById((int)id);
            if (sede == null)
            {
                return NotFound();
            }
            return View(sede);
        }

        // POST: Sedes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdSede,Sede1")] Sede sede)
        {
            if (id != sede.IdSede)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    sedeServices.Update(sede);
                }
                catch (Exception ee)
                {
                    if (!SedeExists(sede.IdSede))
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
            return View(sede);
        }

        // GET: Sedes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sede = sedeServices.GetOneById((int)id);
            if (sede == null)
            {
                return NotFound();
            }

            return View(sede);
        }

        // POST: Sedes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            var sede = sedeServices.GetOneById((int)id);
            sedeServices.Delete(sede);
            return RedirectToAction(nameof(Index));
        }

        private bool SedeExists(int id)
        {
            return (sedeServices.GetOneById((int)id) != null);
        }
    }
}
