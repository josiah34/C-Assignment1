using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace SportsPro.Models
{
    public class Technician
    {
        [DisplayName("Technician")]
        public int TechnicianId { get; set; }


       [Required(ErrorMessage = "Technician name is required")]
       public string Name { get; set; }


       [Required(ErrorMessage = "Technician email is required")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Technician phone number is required")]
        public string Phone { get; set; }
        public string TechName { get { return string.Format("{0}", Name); } }

        public Technician()
        {

        }
    }
}
