using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ToDoMvc.Models;
using ToDoMvc.Models.AccountViewModels;

namespace ToDoMvc.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
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

        public Microsoft.EntityFrameworkCore.DbSet<Cliente> Clientes { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Fornecedor> Fornecedores { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Loja> Lojas { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Marca> Marcas { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Produto> Produtos { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Produto_Venda> Produtos_Vendas { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Setor> Setores { get; set; }
        public DbSet<RegisterViewModel> RegisterViewModel { get; set; }

    }
}
