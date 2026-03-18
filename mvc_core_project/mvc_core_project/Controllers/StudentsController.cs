using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using mvc_core_project.Data;
using mvc_core_project.Models;

namespace mvc_core_project.Controllers
{
    public class StudentsController : Controller
    {
        private readonly CollegeDbContext _context;

        public StudentsController(CollegeDbContext context)
        {
            _context = context;
        }

        // GET: Students
        // This is already correct - it includes the Parent and Stream objects
        public async Task<IActionResult> Index()
        {
            var collegeDbContext = _context.Students.Include(s => s.Parent).Include(s => s.Stream);
            return View(await collegeDbContext.ToListAsync());
        }

        // GET: Students/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Students
                .Include(s => s.Parent)
                .Include(s => s.Stream)
                .FirstOrDefaultAsync(m => m.id == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // GET: Students/Create
        public IActionResult Create()
        {
            // Use "Name" for the display text in the dropdown
            ViewData["ParentId"] = new SelectList(_context.Parents, "Id", "Name");
            ViewData["StreamId"] = new SelectList(_context.Streams, "Id", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,name,StreamId,ParentId")] Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Add(student);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            // If we get here, something failed. Reload dropdowns with Names.
            ViewData["ParentId"] = new SelectList(_context.Parents, "Id", "Name", student.ParentId);
            ViewData["StreamId"] = new SelectList(_context.Streams, "Id", "Name", student.StreamId);
            return View(student);
        }

        // GET: Students/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Students.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            // Use "Name" for the display text in the dropdown
            ViewData["ParentId"] = new SelectList(_context.Parents, "Id", "Name", student.ParentId);
            ViewData["StreamId"] = new SelectList(_context.Streams, "Id", "Name", student.StreamId);
            return View(student);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,name,StreamId,ParentId")] Student student)
        {
            if (id != student.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(student);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentExists(student.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            // Reload dropdowns with Names if validation fails
            ViewData["ParentId"] = new SelectList(_context.Parents, "Id", "Name", student.ParentId);
            ViewData["StreamId"] = new SelectList(_context.Streams, "Id", "Name", student.StreamId);
            return View(student);
        }

        // GET: Students/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Students
                .Include(s => s.Parent)
                .Include(s => s.Stream)
                .FirstOrDefaultAsync(m => m.id == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var student = await _context.Students.FindAsync(id);
            if (student != null)
            {
                _context.Students.Remove(student);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentExists(int id)
        {
            return _context.Students.Any(e => e.id == id);
        }
    }
}