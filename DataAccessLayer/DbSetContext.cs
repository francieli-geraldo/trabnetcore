namespace DataAccessLayer
{
    public partial class Context
    {
        public Microsoft.EntityFrameworkCore.DbSet<Models.Cliente> Clientes { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Models.Fornecedor> Fornecedores{ get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Models.Loja> Lojas { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Models.Marca> Marcas { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Models.Produto> Produtos { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Models.Produto_Venda> Produtos_Vendas { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Models.Setor> Setores { get; set; }
     }
}
