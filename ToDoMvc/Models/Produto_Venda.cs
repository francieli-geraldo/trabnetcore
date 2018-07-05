﻿using System;

namespace ToDoMvc.Models
{
    public class Produto_Venda
    {

        public long Id { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public Decimal ValorUnitario { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public long QuantidadeProduto { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public long ProdutoId { get; set; }
        public Produto Produto { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public long VendaId { get; set; }
        public Venda Venda { get; set; }

    }
}