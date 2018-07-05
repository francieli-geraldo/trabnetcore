using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;


namespace ToDoMvc.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {

        [System.ComponentModel.DataAnnotations.StringLength(100, MinimumLength = 2)]
        public string Name { get; set; }

        [System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
        [System.ComponentModel.DataAnnotations.DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        public System.DateTime DataNascimento { get; set; }

        [System.ComponentModel.DataAnnotations.StringLength(200, MinimumLength = 2)]
        public string Endereco { get; set; }

        [System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.PhoneNumber)]
        public long? Telefone { get; set; }

        [System.ComponentModel.DataAnnotations.StringLength(11, MinimumLength = 11)]
        public long? CPF { get; set; }

        public bool Gerente { get; set; }

        [System.ComponentModel.DataAnnotations.StringLength(100, MinimumLength = 2)]
        public string Sexo { get; set; }

        public long? LojaId { get; set; }
        public Loja Loja { get; set; }

        //public static implicit operator ApplicationUser(ApplicationUser v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
