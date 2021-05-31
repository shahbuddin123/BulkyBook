using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BulkyBook.Models
{
   public class OrderDetails
    {
        [Key]

        public int Id { get; set; }

        [Required]
        public int OrderId { get; set; }
        [ForiegnKey("OrderId")]

        public OrderHeader OrderHeader { get; set; }



        [Required]
        public int ProductId { get; set; }
        [ForiegnKey("OrderId")]

        public OrderHeader Product { get; set; }

        public int Count { get; set; }

        public double Price { get; set; }

    }
}
