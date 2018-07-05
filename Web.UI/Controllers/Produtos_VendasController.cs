﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.UI.Controllers
{
    public class Produto_VendasController : Controller
    {
        private readonly DataAccessLayer.IGenericRepository<Models.Produto_Venda> _repositoryProduto_Venda;
        private readonly DataAccessLayer.IGenericRepository<Models.Venda> _repositoryVenda;
        private readonly DataAccessLayer.IGenericRepository<Models.Produto> _repositoryProduto;
        private readonly UserManager<Models.ApplicationUser> _userManager;

        public Produto_VendasController(
            DataAccessLayer.IGenericRepository<Models.Produto_Venda> repositoryProduto_Venda,
            DataAccessLayer.IGenericRepository<Models.Venda> repositoryVenda,
            DataAccessLayer.IGenericRepository<Models.Produto> repositoryProduto,
            UserManager<Models.ApplicationUser> userManager)
        {
            _repositoryProduto_Venda = repositoryProduto_Venda;
            _repositoryVenda = repositoryVenda;
            _repositoryProduto = repositoryProduto;
            _userManager = userManager;
        }

        // GET: Produto_Vendas
        public async Task<IActionResult> Index()
        {
            return View(await _repositoryProduto_Venda.GetAllAsync());
            //       var currentUser = await _userManager.GetUserAsync(User);

            //    return View(await _repositoryProduto_Venda.GetAllAsync(
            //        v => currentUser.Gerente || v.FuncionarioId == currentUser.Id,
            //        v => v.Cliente));
        }

        // GET: Produto_Vendas/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produto_venda = await _repositoryProduto_Venda.GetAsync(id);
            if (produto_venda == null)
            {
                return NotFound(null);
            }

            return View(produto_venda);
        }

        // GET: Produto_Vendas/Create
        public IActionResult Create()
        {
            ViewData["VendaId"] = new SelectList(_repositoryVenda.GetAll(), "Id", "Id");
            ViewData["ProdutoId"] = new SelectList(_repositoryVenda.GetAll(), "Id", "Nome");
            return View();
        }

        // POST: Produto_Vendas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ValorUnitario,QuantidadeProduto,VendaId,ProdutoId")] Models.Produto_Venda produto_venda)
        {
            if (ModelState.IsValid)
            {
                await _repositoryProduto_Venda.InsertAsync(produto_venda);
                return RedirectToAction(nameof(Index));
            }

            ViewData["VendaId"] = new SelectList(_repositoryVenda.GetAll(), "Id", "Id", produto_venda.VendaId);
            ViewData["ProdutoId"] = new SelectList(_repositoryVenda.GetAll(), "Id", "Nome", produto_venda.ProdutoId);
            return View(produto_venda);
        }

        // GET: Produto_Vendas/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produto_venda = await _repositoryProduto_Venda.GetAsync(id);
            if (produto_venda == null)
            {
                return NotFound();
            }

            ViewData["VendaId"] = new SelectList(_repositoryVenda.GetAll(), "Id", "Id", produto_venda.VendaId);
            ViewData["ProdutoId"] = new SelectList(_repositoryVenda.GetAll(), "Id", "Nome", produto_venda.ProdutoId);
            return View(produto_venda);
        }

        // POST: Produto_Vendas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,ValorUnitario,QuantidadeProduto,VendaId,ProdutoId")] Models.Produto_Venda produto_venda)
        {
            if (id != produto_venda.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _repositoryProduto_Venda.UpdateAsync(id, produto_venda);
                }
                catch (System.Exception)
                {
                    if (!Produto_VendaExists(produto_venda.Id))
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
            ViewData["VendaId"] = new SelectList(_repositoryVenda.GetAll(), "Id", "Id", produto_venda.VendaId);
            ViewData["ProdutoId"] = new SelectList(_repositoryVenda.GetAll(), "Id", "Nome", produto_venda.ProdutoId);
            return View(produto_venda);
        }

        // GET: Produto_Vendas/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produto_venda = await _repositoryProduto_Venda.GetAsync(id);
            if (produto_venda == null)
            {
                return NotFound();
            }

            return View(produto_venda);
        }

        // POST: Produto_Vendas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            await _repositoryProduto_Venda.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        private bool Produto_VendaExists(long id)
        {
            return _repositoryProduto_Venda.Get(id) != null;
        }
    }
}
