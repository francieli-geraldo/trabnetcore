namespace ToDoMvc.Models
{
    public class Fornecedor
    {
        public long Id { get; set; }

        [System.ComponentModel.DataAnnotations.StringLength(100, MinimumLength = 2)]
        public string Name { get; set; }

        [System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.PhoneNumber)]
        [System.ComponentModel.DataAnnotations.Required]
        public long Telefone { get; set; }

        [System.ComponentModel.DataAnnotations.RangeAttribute(1,15)]
        [System.ComponentModel.DataAnnotations.Required]
        public long CNPJ { get; set; }
    }
}