using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SportsPro.Data;
using SportsPro.Models;

namespace SportsPro.Controllers
{
    public class CountryController : Controller
    {
        private ApplicationDbContext _context;
        public CountryController(ApplicationDbContext context)
        {
            _context = context;
        }
       public IActionResult Index()
        {
            List<Country> li = new List<Country>();
            li = _context.Countries.OrderBy(c => c.CountryName).ToList();
            ViewBag.listofitems = li;
            return View();
        }

    }
}
