using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportsPro.Models
{
    public class Incident
    {
        public  int IncidentId { get; set; }

        [Required(ErrorMessage = "Customer is a required field")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }


        [Required(ErrorMessage = "Product is a required field")]
        public int ProductId { get; set; }

        public Product Product { get; set; }

        [Required(ErrorMessage = "Title is a required field")]
        public string Title { get; set; }


        [Required(ErrorMessage = "Description is a required field")]
        public string Description { get; set; }

        public int? TechnicianId { get; set; }

        public Technician Technician { get; set; }


        public DateTime DateOpened { get; set; }

        public DateTime DateClosed { get; set; }


        public Incident()
        {

        }


       

    }
}
