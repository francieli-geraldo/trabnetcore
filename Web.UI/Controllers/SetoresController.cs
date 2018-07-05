using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Web.UI.Data;

namespace Web.UI.Controllers
{
    public class SetoresController : Controller
    {
        private readonly DataAccessLayer.IGenericRepository<Models.Setor> _repositorySetor;

        public SetoresController(DataAccessLayer.IGenericRepository<Models.Setor> repositorySetor)
        {
            _repositorySetor = repositorySetor;
        }

        // GET: Setores
        public async Task<IActionResult> Index()
        {
            return View(await _repositorySetor.GetAllAsync());
        }

        // GET: Setores/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var setor = await _repositorySetor.GetAsync(id.Value);

            if (setor == null)
            {
                return NotFound();
            }

            return View(setor);
        }

        // GET: Setores/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Setores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] Models.Setor setor)
        {
            if (ModelState.IsValid)
            {
                await _repositorySetor.InsertAsync(setor);
                return RedirectToAction(nameof(Index));
            }
            return View(setor);
        }

        // GET: Setores/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var setor = await _repositorySetor.GetAsync(id);
            if (setor == null)
            {
                return NotFound();
            }
            return View(setor);
        }

        // POST: Setores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Name")] Models.Setor setor)
        {
            if (id != setor.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _repositorySetor.UpdateAsync(id, setor);
                return RedirectToAction(nameof(Index));
            }
            return View(setor);
        }

        // GET: Setores/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            var setor = await _repositorySetor.GetAsync(id);
            if (setor == null)
            {
                return NotFound();
            }

            return View(setor);
        }

        // POST: Setores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {

            await _repositorySetor.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
         }

    }
}
