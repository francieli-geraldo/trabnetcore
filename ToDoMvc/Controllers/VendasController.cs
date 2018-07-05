using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoMvc.Models;
using ToDoMvc.Services;

namespace ToDoMvc.Controllers
{
    public class VendasController : Controller
    {
        private readonly IGenericRepository<Venda> _repositoryVenda;
        private readonly IGenericRepository<Cliente> _repositoryCliente;
        private readonly UserManager<ApplicationUser> _userManager;

        public VendasController(
            IGenericRepository<Venda> repositoryVenda,
            IGenericRepository<Cliente> repositoryCliente,
            UserManager<ApplicationUser> userManager)
        {
            _repositoryVenda = repositoryVenda;
            _repositoryCliente = repositoryCliente;
            _userManager = userManager;
        }

        // GET: Vendas
        public async Task<IActionResult> Index()
        {
            var currentUser = await _userManager.GetUserAsync(User);

            return View(await _repositoryVenda.GetAllAsync(
                v => currentUser.Gerente || v.FuncionarioId == currentUser.Id,
                v => v.Cliente));
        }

        // GET: Vendas/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var venda = await _repositoryVenda.GetAsync(id);
            if (venda == null)
            {
                return NotFound(null);
            }

            return View(venda);
        }

        // GET: Vendas/Create
        public IActionResult Create()
        {
            ViewData["ClienteId"] = new SelectList(_repositoryCliente.GetAll(), "Id", "Name");
            ViewData["FuncionarioId"] = new SelectList( _userManager.GetUserName(User));
            return View();
        }

        // POST: Vendas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DescricaoVenda,ValorTotal,DataVenda,FormaPagamento,Fechado,ClienteId")] Venda venda)
        {
            if (ModelState.IsValid)
            {
                var func = await _userManager.GetUserAsync(User);
                venda.FuncionarioId = func.Id;

                await _repositoryVenda.InsertAsync(venda);
                return RedirectToAction("Edit", new { id = venda.Id });
            }

            ViewData["ClienteId"] = new SelectList(_repositoryCliente.GetAll(), "Id", "Name", venda.ClienteId);
            ViewData["FuncionarioId"] = new SelectList(_userManager.GetUserName(User), venda.FuncionarioId);
            return View(venda);
        }

        // GET: Vendas/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var venda = await _repositoryVenda.GetAsync(id);
            if (venda == null)
            {
                return NotFound();
            }

            ViewData["ClienteId"] = new SelectList(_repositoryCliente.GetAll(), "Id", "Name", venda.ClienteId);
            ViewData["FuncionarioId"] = new SelectList(_userManager.GetUserName(User), venda.FuncionarioId);
            return View(venda);
        }

        // POST: Vendas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,DescricaoVenda,ValorTotal,DataVenda,FormaPagamento,Fechado,ClienteId,FuncionarioId")] Venda venda)
        {
            if (id != venda.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _repositoryVenda.UpdateAsync(id, venda);
                }
                catch (System.Exception)
                {
                    if (!VendaExists(venda.Id))
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
            ViewData["ClienteId"] = new SelectList(_repositoryCliente.GetAll(), "Id", "Name", venda.ClienteId);
            ViewData["FuncionarioId"] = new SelectList(_userManager.GetUserName(User), venda.FuncionarioId);
            return View(venda);
        }

        // GET: Vendas/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var venda = await _repositoryVenda.GetAsync(id);
            if (venda == null)
            {
                return NotFound();
            }

            return View(venda);
        }

        // POST: Vendas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            await _repositoryVenda.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        private bool VendaExists(long id)
        {
            return _repositoryVenda.Get(id) != null;
        }
    }
}
