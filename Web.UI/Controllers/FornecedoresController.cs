using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Web.UI.Controllers
{
    public class FornecedoresController : Controller
    {
        private readonly DataAccessLayer.IGenericRepository<Models.Fornecedor> _repositoryFornecedor;

        public FornecedoresController(DataAccessLayer.IGenericRepository<Models.Fornecedor> repositoryFornecedor)
        {
            _repositoryFornecedor = repositoryFornecedor;
        }

        // GET: Fornecedores
        public async Task<IActionResult> Index()
        {
            return View(await _repositoryFornecedor.GetAllAsync());
        }

        // GET: Fornecedores/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fornecedor = await _repositoryFornecedor.GetAsync(id.Value);

            if (fornecedor == null)
            {
                return NotFound();
            }

            return View(fornecedor);
        }

        // GET: Fornecedores/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Fornecedores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Telefone,CNPJ")] Models.Fornecedor fornecedor)
        {
            if (ModelState.IsValid)
            {
                await _repositoryFornecedor.InsertAsync(fornecedor);
                return RedirectToAction(nameof(Index));
            }
            return View(fornecedor);
        }

        // GET: Fornecedores/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fornecedor = await _repositoryFornecedor.GetAsync(id.Value);
            if (fornecedor == null)
            {
                return NotFound();
            }
            return View(fornecedor);
        }

        // POST: Fornecedores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Name,Telefone,CNPJ")] Models.Fornecedor fornecedor)
        {
            if (id != fornecedor.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _repositoryFornecedor.UpdateAsync(id, fornecedor);
                return RedirectToAction(nameof(Index));
            }
            return View(fornecedor);
        }

        // GET: Fornecedores/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fornecedor = await _repositoryFornecedor.GetAsync(id);
            if (fornecedor == null)
            {
                return NotFound();
            }

            return View(fornecedor);
        }

        // POST: Fornecedores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            await _repositoryFornecedor.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
