using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        [StringLength(60,MinimumLength =10,ErrorMessage = "Name should between 10 to 60 characters.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "You must enter a price value!")]
        [Range(1, 10000)]
        public decimal? Price { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 10, ErrorMessage = "Description should between 10 to 60 characters.")]
        public string Description { get; set; }
        [Required]
        public string ImageUrl { get; set; }

        public bool IsApproved { get; set; }
        [Required]
        public int? CategoryId { get; set; }
    }
}
