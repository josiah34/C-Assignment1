using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SportsPro.Models
{
    public class Technician
    {
        
       public int TechnicianId { get; set; }


       [Required(ErrorMessage = "Technician name is required")]
       public string Name { get; set; }


       [Required(ErrorMessage = "Technician email is required")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Technician phone number is required")]
        public string Phone { get; set; }

        public Technician()
        {

        }
    }
}
