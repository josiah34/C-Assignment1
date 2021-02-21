using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportsPro.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "First name is required")]
        public string Firstname { get; set; }


        [Required(ErrorMessage = "Last name is required")]
        public string Lastname { get; set; }


        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }

        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }

        [Required(ErrorMessage = "Province/State is required")]
        public string State { get; set; }

        [Required(ErrorMessage = "Postal code is required")]
        public string PostalCode { get; set; }
        
        
        [Required(ErrorMessage = "Country is required")]
        public string Country { get; set; }

        public string Email { get; set; }


        [Required(ErrorMessage = "Phone number is required")]
        public string Phone { get; set; }

        public Customer()
        {

        }
    }
}
