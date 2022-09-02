using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GB.Models
{
    public class Supplier
    {

        [Key]
        public int SupplierId { get; set; }

        [Required(ErrorMessage = "Ingresa Un CompanyName")]
        [Display(Name = "Nombre CompanyName")]
        public string CompanyName { get; set; }

        public string Phone { get; set; }

        public ICollection<Product> Product { get; set; }
    }
}
