namespace ToDoMvc.Models.View
{
    public class Produto_VendaVM : Produto_Venda
    {
        public decimal Total { get { return this.QuantidadeProduto * this.ValorUnitario; } }
    }
}
