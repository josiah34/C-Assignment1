using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace SportsPro.Models
{
    public class Product
    {
        [DisplayName("Product")]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Product code is required")]
        public string Code { get; set; }


        [Required(ErrorMessage = "Product name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Product price is required")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Release date is required")]
        [DisplayName("Release Date")]
        public DateTime ReleaseDate { get; set; }

        public Product()
        {
             
        }

    }
}
