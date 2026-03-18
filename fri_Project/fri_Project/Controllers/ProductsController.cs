using fri_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace fri_Project.Controllers
{
    public class ProductsController : Controller
    {
        private readonly FoodDeliveryContext _context;

        public ProductsController(FoodDeliveryContext context)
        {
            _context = context;
        }

        // GET: Products
        public IActionResult Index()
        {
            // Use .Include to load the category name via the foreign key
            List<Product> products = _context.Products.Include(e => e.Category).ToList();
            return View(products);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            // Creates the dropdown list using ViewBag
            ViewBag.Categid = new SelectList(_context.Categories.ToList(), "Id", "Name");
            return View();
        }

        // POST: Products/Create
        [HttpPost]
        public IActionResult Create(Product p)
        {
            if (!ModelState.IsValid)
            {
                return View(p);
            }
            else
            {
                _context.Products.Add(p);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        // GET: Products/Edit/5
        public IActionResult Edit(int id)
        {
            return View(_context.Products.Find(id));
        }

        // POST: Products/Edit
        [HttpPost]
        public IActionResult Edit(Product p)
        {
            _context.Products.Update(p);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}