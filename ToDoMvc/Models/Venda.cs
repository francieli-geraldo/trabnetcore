using System;

namespace ToDoMvc.Models
{
    public class Venda
    {
        public long Id { get; set; }

        public string DescricaoVenda { get; set; }

        public decimal ValorTotal { get; set; }

        [System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
        [System.ComponentModel.DataAnnotations.DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime DataVenda { get; set; }

        public string FormaPagamento { get; set; }

        public bool Fechado { get; set; }

        //public long ProdutoId { get; set; }
        //public Produto Produto { get; set; }

        public long ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public string FuncionarioId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}