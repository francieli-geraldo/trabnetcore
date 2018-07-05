namespace DataAccessLayer.Models
{ 
    public class Loja
    {
        public long Id { get; set; }

        [System.ComponentModel.DataAnnotations.StringLength(100, MinimumLength = 2)]
        public string Name { get; set; }

        [System.ComponentModel.DataAnnotations.StringLength(200, MinimumLength = 2)]
        public string Endereco { get; set; }

        [System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.PhoneNumber)]
        [System.ComponentModel.DataAnnotations.Required]
        public long Telefone { get; set; }

        public string Email { get; set; }

        [System.ComponentModel.DataAnnotations.RangeAttribute(1, 14)]
        [System.ComponentModel.DataAnnotations.Required]
        public long CNPJ { get; set; }
    }
}