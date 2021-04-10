using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using SportsPro.Controllers;

namespace SportsPro.Models
{
    public class Customer
    {
        [DisplayName("Customer")]
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "First name is required")]
        [StringLength(51, MinimumLength = 1, ErrorMessage = "First name must be between 1 and 51 character in length.")]
        [DisplayName("First Name")]
        public string Firstname { get; set; }


        [Required(ErrorMessage = "Last name is required")]
        [StringLength(51, MinimumLength = 1, ErrorMessage = "Last Name must be between 1 and 51 character in length.")]
        [DisplayName("Last Name")]
        public string Lastname { get; set; }


        [Required(ErrorMessage = "Address is required")]
        [StringLength(51, MinimumLength = 1, ErrorMessage = "Address must be between 1 and 51 character in length.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "City is required")]
        [StringLength(51, MinimumLength = 1, ErrorMessage = "City must be between 1 and 51 character in length.")]
        public string City { get; set; }

        [Required(ErrorMessage = "Province/State is required")]
        [StringLength(51, MinimumLength = 1, ErrorMessage = "Province/State must be between 1 and 51 character in length.")]
        public string State { get; set; }

        [Required(ErrorMessage = "Postal code is required")]
        [StringLength(21, MinimumLength = 1, ErrorMessage = "Postal Code  must be between 1 and 51 character in length.")]
        [DisplayName("Postal Code")]
        public string PostalCode { get; set; }
        
        
        [Required(ErrorMessage = "Country is required")]
        public string Country { get; set; }


        
        [EmailAddress(ErrorMessage = "Please enter valid email format")]
        [EmailUserUnique]
        public string Email { get; set; }


        [Required(ErrorMessage = "Phone number is required")]

        public string Phone { get; set; }

        [DisplayName("Customer")]
        public string Fullname { get { return string.Format("{0} {1}", Firstname, Lastname); } }

        public Customer()
        {

        }
        public List<KeyValuePair<string, string>> countryList

        {
            get
            {
                List<KeyValuePair<string, string>> listOfCountries = new List<KeyValuePair<string, string>>();
                CultureInfo[] getCultureInfo = CultureInfo.GetCultures(CultureTypes.SpecificCultures);

                foreach (CultureInfo getCulture in getCultureInfo)
                {
                    RegionInfo GetRegionInfo = new RegionInfo(getCulture.LCID);
                    var countryName = new KeyValuePair<string, string>(GetRegionInfo.EnglishName, GetRegionInfo.EnglishName);
                    if (!(listOfCountries.Contains(countryName)))
                    {
                        listOfCountries.Add(countryName);
                    } 
                }
                return listOfCountries.OrderBy(o => o.Key).ToList();

            }
        }
    }
}
