namespace DataAccessLayer.Models
{
    public class Setor
    {
        public long Id { get; set; }

        [System.ComponentModel.DataAnnotations.StringLength(200, MinimumLength = 2)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
    }
}