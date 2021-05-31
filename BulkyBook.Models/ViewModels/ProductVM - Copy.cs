using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BulkyBook.Models.ViewModels
{
   public class CoverType
    {
        [Key]

        public int Id { get; set; }

        [Display(Name ="CoverType")]
        [Required]

        public string Name { get; set; }


    }
}
