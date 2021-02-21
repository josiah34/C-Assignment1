using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using SportsPro.Models;

namespace SportsPro.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<SportsPro.Models.Customer> Customer { get; set; }
        public DbSet<SportsPro.Models.Incident> Incident { get; set; }
        public DbSet<SportsPro.Models.Product> Product { get; set; }
        public DbSet<SportsPro.Models.Technician> Technician { get; set; }


        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);
            modelbuilder.Entity<Customer>().HasData(
                new Customer
                {
                    CustomerId = 1,
                    Firstname = "Joe",
                    Lastname = "Smith",
                    Address = "1010 Dead End Drive",
                    City = "Toronto",
                    State = "Ontario",
                    PostalCode = "L4R RY9",
                    Country = "Canada",
                    Email = "joe.smith@customer.com",
                    Phone = "416-967-1111"

                },

                new Customer
                  {
                      CustomerId = 2,
                      Firstname = "Moe",
                      Lastname = "Smith",
                      Address = "2020 Dead End Drive",
                      City = "Toronto",
                      State = "Ontario",
                      PostalCode = "L4R RY9",
                      Country = "Canada",
                      Email = "moe.smith@customer.com",
                      Phone = "416-447-1111"

                  },

                new Customer
                    {
                        CustomerId = 3,
                        Firstname = "Andrea",
                        Lastname = "Smith",
                        Address = "3010 Dead End Drive",
                        City = "Toronto",
                        State = "Ontario",
                        PostalCode = "L4R RY9",
                        Country = "Canada",
                        Email = "andrea.smith@customer.com",
                        Phone = "416-444-1111"

                    }





                );
            modelbuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1,
                    Code = "G4569",
                    Name = "Event System",
                    Price = 1525.99,
                    ReleaseDate = DateTime.Now


                },
                new Product
                  {
                      ProductId = 2,
                      Code = "G4568",
                      Name = "Staff Management Software",
                      Price = 1525.99,
                      ReleaseDate = DateTime.Now


                  },
                new Product
                    {
                        ProductId = 3,
                        Code = "G4564",
                        Name = "Registration Software",
                        Price = 1525.99,
                        ReleaseDate = DateTime.Now


                    }
                );
            modelbuilder.Entity<Technician>().HasData(
               new Technician
               {
                   TechnicianId = 1,
                   Name = "Michael Santos",
                   Phone = "647=777-7777",
                   Email = "michael.santos@sportspro.com",


               },
               new Technician
               {
                   TechnicianId = 2,
                   Name = "Lebron James",
                   Phone = "647=777-7777",
                   Email = "lebron.james@sportspro.com",


               },
               new Technician
               {
                   TechnicianId = 3,
                   Name = "Edwin Santon",
                   Phone = "647=777-7777",
                   Email = "edwinsantos@sportspro.com",


               }
               );
            modelbuilder.Entity<Incident>().HasData(
               new Incident
               { 
                   IncidentId =1,
                   CustomerId = 1,
                   ProductId = 1,
                   TechnicianId = 3,
                   Title = "Event System crashes",
                   Description = "System is constantly crashing. Will not open",
                   DateOpened = DateTime.Now,



               },
               new Incident
               { 
                   IncidentId = 2,
                   CustomerId = 2,
                   ProductId = 2,
                   TechnicianId = 1,
                   Title = "Staff management system issue",
                   Description = "Im having issues adding new staff to the system. Please Advise",
                   DateOpened = DateTime.Now,



               },
               new Incident
               {
                   IncidentId = 3,
                   CustomerId = 3,
                   ProductId = 3,
                   TechnicianId = 2,
                   Title = "Registration system frozen",
                   Description = "I am trying to create a new event for the registration but it crashes when I click submit.",
                   DateOpened = DateTime.Now,

               }
            );
               
        }
    }
}
