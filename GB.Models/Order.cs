using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GB.Models
{
    public class Order
    {

        [Key]
        public int OrderId { get; set; }


        [Required(ErrorMessage = "Ingresa Un OrderNumber")]
        [Display(Name = "Nombre OrderNumber")]
        public string OrderNumber { get; set; }

        [Required(ErrorMessage = "Ingresa Un OrdarDate")]
        [Display(Name = "OrdarDate")]
        public DateTime  OrdarDate { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [ForeignKey("CustomerId")]

        public Customer Customer { get; set; }

        public decimal TotalAmount { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }

    }
}
