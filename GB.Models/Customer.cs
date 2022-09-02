using System.ComponentModel.DataAnnotations;

namespace GB.Models
{
    public class Customer
    {

        [Key]
        public int CustomerId { get; set; }
       

        [Required(ErrorMessage = "Ingresa Un nombre para la CustomerName")]
        [Display(Name = "Nombre Customer")]
        public string CustomerName { get; set; }

        [Display(Name = "Phone")]
        public string Phone { get; set; }

    }
}
