using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GB.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Ingresa Un CompanyName")]
        [Display(Name = "Nombre ProductName")]
        public string ProductName { get; set; }
        [Required]
        public int SupplierId { get; set; }

        [ForeignKey("SupplierId")]
        public Supplier Supplier { get; set; }

        public decimal UnitPrice { get; set; }

        public bool IsDiscontinued { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
