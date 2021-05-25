using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BulkyBook.Models
{
     public class category
    {
        public string ImageUrl;

        [Key]
        public int Id { get; set; }
        [Display (Name="Category Name")]
        [Required]
        [MaxLength(50)]

        public string Name { get; set; }
    }
}
