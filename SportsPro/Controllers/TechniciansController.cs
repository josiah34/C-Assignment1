﻿using System;
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
    public class TechniciansController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TechniciansController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Technicians
        public async Task<IActionResult> Index()
        {
            return View(await _context.Technician.ToListAsync());
        }

        // GET: Technicians/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var technician = await _context.Technician
                .FirstOrDefaultAsync(m => m.TechnicianId == id);
            if (technician == null)
            {
                return NotFound();
            }

            return View(technician);
        }

        // GET: Technicians/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Technicians/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TechnicianId,Name,Email,Phone")] Technician technician)
        {
            if (ModelState.IsValid)
            {
                _context.Add(technician);
                await _context.SaveChangesAsync();
                TempData["message"] = $"{technician.Name} has been added to Technicians";
                return RedirectToAction(nameof(Index));
            }
            return View(technician);
        }

        // GET: Technicians/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var technician = await _context.Technician.FindAsync(id);
            if (technician == null)
            {
                return NotFound();
            }
            return View(technician);
        }

        // POST: Technicians/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TechnicianId,Name,Email,Phone")] Technician technician)
        {
            if (id != technician.TechnicianId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(technician);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TechnicianExists(technician.TechnicianId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                TempData["message"] = $"{technician.Name} has been edited";
                return RedirectToAction(nameof(Index));
            }
            return View(technician);
        }

        // GET: Technicians/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var technician = await _context.Technician
                .FirstOrDefaultAsync(m => m.TechnicianId == id);
            if (technician == null)
            {
                return NotFound();
            }

            return View(technician);
        }

        // POST: Technicians/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var technician = await _context.Technician.FindAsync(id);
            _context.Technician.Remove(technician);
            await _context.SaveChangesAsync();
            TempData["message"] = $"{technician.Name} has been deleted from Technicians";
            return RedirectToAction(nameof(Index));
        }

        private bool TechnicianExists(int id)
        {
            return _context.Technician.Any(e => e.TechnicianId == id);
        }
    }
}
