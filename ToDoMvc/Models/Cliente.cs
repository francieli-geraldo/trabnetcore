using System.ComponentModel.DataAnnotations;

namespace ToDoMvc.Models
{
    public class Cliente
    {
        public long Id { get; set; }

        [System.ComponentModel.DataAnnotations.StringLength(100, MinimumLength = 2)]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = false)]
        public System.DateTime DataNascimento { get; set; }

        public string Endereco { get; set; }

        [System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.PhoneNumber)]
        [System.ComponentModel.DataAnnotations.Required]
        public long Telefone { get; set; }

        public string Email { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public long CPF { get; set; }
    }
}
