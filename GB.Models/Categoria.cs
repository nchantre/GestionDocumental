using System.ComponentModel.DataAnnotations;

namespace GB.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Ingresa Un nombre para la categoria")]
        [Display(Name = "Nombre Categoría")]
        public string Nombre { get; set; }

        [Required]
        [Display(Name = "Orden de visualización")]
        public int Orden { get; set; }

    }
}
