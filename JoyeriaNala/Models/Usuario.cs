using System.ComponentModel.DataAnnotations;

namespace JoyeriaNala.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string usuario { get; set; }
        [Required]
        public string Contraseña { get; set; }
    }
}
