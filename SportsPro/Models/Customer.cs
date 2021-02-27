﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace SportsPro.Models
{
    public class Customer
    {
        [DisplayName("Customer")]
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "First name is required")]
        [DisplayName("First Name")]
        public string Firstname { get; set; }


        [Required(ErrorMessage = "Last name is required")]
        [DisplayName("Last Name")]
        public string Lastname { get; set; }


        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }

        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }

        [Required(ErrorMessage = "Province/State is required")]
        public string State { get; set; }

        [Required(ErrorMessage = "Postal code is required")]
        [DisplayName("Postal Code")]
        public string PostalCode { get; set; }
        
        
        [Required(ErrorMessage = "Country is required")]
        public string Country { get; set; }

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
