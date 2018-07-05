using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.UI.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly DataAccessLayer.IGenericRepository<Models.Produto> _repositoryProduto;
        private readonly DataAccessLayer.IGenericRepository<Models.Setor> _repositorySetor;
        private readonly DataAccessLayer.IGenericRepository<Models.Marca> _repositoryMarca;
        private readonly DataAccessLayer.IGenericRepository<Models.Fornecedor> _repositoryFornecedor;
        private readonly UserManager<Models.ApplicationUser> _userManager;

        public ProdutosController(
            DataAccessLayer.IGenericRepository<Models.Produto> repositoryProduto,
            DataAccessLayer.IGenericRepository<Models.Setor> repositorySetor,
            DataAccessLayer.IGenericRepository<Models.Marca> repositoryMarca,
            DataAccessLayer.IGenericRepository<Models.Fornecedor> repositoryFornecedor,
            UserManager<Models.ApplicationUser> userManager)
        {
            _repositoryProduto = repositoryProduto;
            _repositorySetor = repositorySetor;
            _repositoryMarca = repositoryMarca;
            _repositoryFornecedor = repositoryFornecedor;
            _userManager = userManager;
        }

        // GET: Produtos
        public async Task<IActionResult> Index()
        {
            return View(await _repositoryProduto.GetAllAsync());
        //       var currentUser = await _userManager.GetUserAsync(User);

        //    return View(await _repositoryProduto.GetAllAsync(
        //        v => currentUser.Gerente || v.FuncionarioId == currentUser.Id,
        //        v => v.Cliente));
        }

        // GET: Produtos/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produto = await _repositoryProduto.GetAsync(id);
            if (produto == null)
            {
                return NotFound(null);
            }

            return View(produto);
        }

        // GET: Produtos/Create
        public IActionResult Create()
        {
            ViewData["SetorId"] = new SelectList(_repositorySetor.GetAll(), "Id", "Nome");
            ViewData["MarcaId"] = new SelectList(_repositoryMarca.GetAll(), "Id", "Nome");
            ViewData["FornecedorId"] = new SelectList(_repositorySetor.GetAll(), "Id", "Nome");
            return View();
        }

        // POST: Produtos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,DescricaoProduto,Valor,MarcaId,SetorId,FornecedorId")] Models.Produto produto)
        {
            if (ModelState.IsValid)
            {
                await _repositoryProduto.InsertAsync(produto);
                return RedirectToAction(nameof(Index));
            }

            ViewData["SetorId"] = new SelectList(_repositorySetor.GetAll(), "Id", "Nome", produto.SetorId);
            ViewData["MarcaId"] = new SelectList(_repositoryMarca.GetAll(), "Id", "Nome", produto.MarcaId);
            ViewData["FornecedorId"] = new SelectList(_repositorySetor.GetAll(), "Id", "Nome", produto.FornecedorId);
            return View(produto);
        }

        // GET: Produtos/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produto = await _repositoryProduto.GetAsync(id);
            if (produto == null)
            {
                return NotFound();
            }

            ViewData["SetorId"] = new SelectList(_repositorySetor.GetAll(), "Id", "Nome", produto.SetorId);
            ViewData["MarcaId"] = new SelectList(_repositoryMarca.GetAll(), "Id", "Nome", produto.MarcaId);
            ViewData["FornecedorId"] = new SelectList(_repositorySetor.GetAll(), "Id", "Nome", produto.FornecedorId);
            return View(produto);
        }

        // POST: Produtos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Name,DescricaoProduto,Valor,MarcaId,SetorId,FornecedorId")] Models.Produto produto)
        {
            if (id != produto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _repositoryProduto.UpdateAsync(id, produto);
                }
                catch (System.Exception)
                {
                    if (!ProdutoExists(produto.Id))
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
            ViewData["SetorId"] = new SelectList(_repositorySetor.GetAll(), "Id", "Nome", produto.SetorId);
            ViewData["MarcaId"] = new SelectList(_repositoryMarca.GetAll(), "Id", "Nome", produto.MarcaId);
            ViewData["FornecedorId"] = new SelectList(_repositorySetor.GetAll(), "Id", "Nome", produto.FornecedorId);
            return View(produto);
        }

        // GET: Produtos/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produto = await _repositoryProduto.GetAsync(id);
            if (produto == null)
            {
                return NotFound();
            }

            return View(produto);
        }

        // POST: Produtos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            await _repositoryProduto.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        private bool ProdutoExists(long id)
        {
            return _repositoryProduto.Get(id) != null;
        }
    }
}
