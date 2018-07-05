using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ToDoMvc.Data;
using ToDoMvc.Models;
using ToDoMvc.Services;

namespace ToDoMvc.Controllers
{
    public class MarcasController : Controller
    {
        private readonly IGenericRepository<Marca> _repositoryMarca;

        public MarcasController(IGenericRepository<Marca> repositoryMarca)
        {
            _repositoryMarca = repositoryMarca;
        }

        // GET: Marcas
        public async Task<IActionResult> Index()
        {
            return View(await _repositoryMarca.GetAllAsync());
        }

        // GET: Marcas/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var marca = await _repositoryMarca.GetAsync(id.Value);

            if (marca == null)
            {
                return NotFound();
            }

            return View(marca);
        }

        // GET: Marcas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Marcas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] Marca marca)
        {
            if (ModelState.IsValid)
            {
                await _repositoryMarca.InsertAsync(marca);
                return RedirectToAction(nameof(Index));
            }
            return View(marca);
        }

        // GET: Marcas/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var marca = await _repositoryMarca.GetAsync(id);
            if (marca == null)
            {
                return NotFound();
            }
            return View(marca);
        }

        // POST: Marcas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Name")] Marca marca)
        {
            if (id != marca.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _repositoryMarca.UpdateAsync(id, marca);
                return RedirectToAction(nameof(Index));
            }
            return View(marca);
        }

        // GET: Marcas/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            var marca = await _repositoryMarca.GetAsync(id);
            if (marca == null)
            {
                return NotFound();
            }

            return View(marca);
        }

        // POST: Marcas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {

            await _repositoryMarca.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
         }

    }
}
