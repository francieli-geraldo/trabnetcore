using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Web.UI.Controllers
{
    public class LojasController : Controller
    {
        private readonly DataAccessLayer.IGenericRepository<Models.Loja> _repositoryLoja;

        public LojasController(DataAccessLayer.IGenericRepository<Models.Loja> repositoryLoja)
        {
            _repositoryLoja = repositoryLoja;
        }

        // GET: Lojas
        public async Task<IActionResult> Index()
        {
            return View(await _repositoryLoja.GetAllAsync());
        }

        // GET: Lojas/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _repositoryLoja.GetAsync(id.Value);

            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        // GET: Lojas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Lojas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Endereco,Telefone,Email,CNPJ")] Models.Loja cliente)
        {
            if (ModelState.IsValid)
            {
                await _repositoryLoja.InsertAsync(cliente);
                return RedirectToAction(nameof(Index));
            }
            return View(cliente);
        }

        // GET: Lojas/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _repositoryLoja.GetAsync(id.Value);
            if (cliente == null)
            {
                return NotFound();
            }
            return View(cliente);
        }

        // POST: Lojas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Name,Endereco,Telefone,Email,CNPJ")] Models.Loja cliente)
        {
            if (id != cliente.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _repositoryLoja.UpdateAsync(id, cliente);
                return RedirectToAction(nameof(Index));
            }
            return View(cliente);
        }

        // GET: Lojas/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _repositoryLoja.GetAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        // POST: Lojas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            await _repositoryLoja.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
