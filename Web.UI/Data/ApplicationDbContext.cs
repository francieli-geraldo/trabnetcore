using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Models;
using Web.UI.Models.AccountViewModels;

namespace Web.UI.Data
{
    public class ApplicationDbContext : IdentityDbContext<Models.ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }


        public DbSet<Models.Cliente> Clientes { get; set; }
        public DbSet<Models.Fornecedor> Fornecedores { get; set; }
        public DbSet<Models.Loja> Lojas { get; set; }
        public DbSet<Models.Marca> Marcas { get; set; }
        public DbSet<Models.Produto> Produtos { get; set; }
        public DbSet<Models.Produto_Venda> Produtos_Vendas { get; set; }
        public DbSet<Models.Setor> Setores { get; set; }
        public DbSet<Models.Venda> Vendas { get; set; }
        public DbSet<Web.UI.Models.AccountViewModels.RegisterViewModel> RegisterViewModel { get; set; }
        }
}