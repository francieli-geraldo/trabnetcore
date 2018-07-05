using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.UI.Controllers
{
    public class FuncionariosController : Controller
    {
        private readonly DataAccessLayer.IGenericRepository<Models.Loja> _repositoryLoja;
        private readonly UserManager<Models.ApplicationUser> _userManager;

        public FuncionariosController(
            DataAccessLayer.IGenericRepository<Models.Loja> repositoryLoja,
            UserManager<Models.ApplicationUser> userManager)
        {
            _repositoryLoja = repositoryLoja;
            _userManager = userManager;
        }

        // GET: Funcionarios
        public async Task<IActionResult> Index()
        {
            return View(await Task.Run(() =>_userManager.Users.ToList()));
            //       var currentUser = await _userManager.GetUserAsync(User);

            //    return View(await _userManager.GetAllAsync(
            //        v => currentUser.Gerente || v.FuncionarioId == currentUser.Id,
            //        v => v.Cliente));
        }

        // GET: Funcionarios/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var funcionario = await _userManager.GetUserAsync(User);
            if (funcionario == null)
            {
                return NotFound(null);
            }

            return View(funcionario);
        }

        // GET: Funcionarios/Create
        public IActionResult Create()
        {
            ViewData["LojaId"] = new SelectList(_repositoryLoja.GetAll(), "Id", "Nome");
            return View();
        }

        // POST: Funcionarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FuncionarioId,Email,Password,Name,DataNascimento,Endereco,Telefone,CPF, Gerente, Sexo, LojaId")] Models.AccountViewModels.RegisterViewModel funcionario)
        {
            if (ModelState.IsValid)
            {
                var user = new Models.ApplicationUser { UserName = funcionario.Name, Email = funcionario.Email };
                await _userManager.CreateAsync(user, funcionario.Email);
                return RedirectToAction(nameof(Index));
            }

            ViewData["LojaId"] = new SelectList(_repositoryLoja.GetAll(), "Id", "Nome", funcionario.LojaId);
            return View(funcionario);
        }

        // GET: Funcionarios/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var funcionario = await _userManager.GetUserAsync(User);
            if (funcionario == null)
            {
                return NotFound();
            }

            ViewData["LojaId"] = new SelectList(_repositoryLoja.GetAll(), "Id", "Nome", funcionario.LojaId);
            return View(funcionario);
        }

        // POST: Funcionarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("FuncionarioId,Email,Password,Name,DataNascimento,Endereco,Telefone,CPF, Gerente, Sexo, LojaId")] Models.AccountViewModels.RegisterViewModel funcionario)
        {
            if (id != funcionario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var user = new Models.ApplicationUser { UserName = funcionario.Name, Email = funcionario.Email };
                    await _userManager.UpdateAsync(user);
                }
                catch (System.Exception)
                {
                    if (!FuncionarioExists(funcionario.Id))
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
            ViewData["LojaId"] = new SelectList(_repositoryLoja.GetAll(), "Id", "Nome", funcionario.LojaId);
            return View(funcionario);
        }

        // GET: Funcionarios/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var funcionario = await _userManager.DeleteAsync(await _userManager.GetUserAsync(User));
            if (funcionario == null)
            {
                return NotFound();
            }

            return View(funcionario);
        }

        // POST: Funcionarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            await _userManager.DeleteAsync(await _userManager.GetUserAsync(User));
            return RedirectToAction(nameof(Index));
        }

        private bool FuncionarioExists(long id)
        {
            return _userManager.GetUserId(User) != null;
        }
    }
}