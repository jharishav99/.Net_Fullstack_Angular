using Microsoft.AspNetCore.Mvc;
using WebApplication1.DAL;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PatientController : Controller
    {
        private readonly CRUD _crud;

        public PatientController(CRUD crud)
        {
            _crud = crud;
        }

        // LIST
        public IActionResult Index()
        {
            var list = _crud.GetPatients();
            return View(list);
        }

        // CREATE GET
        public IActionResult Create()
        {
            return View();
        }

        // CREATE POST
        [HttpPost]
        public IActionResult Create(Patient p)
        {
            _crud.InsertPatient(p);
            return RedirectToAction("Index");
        }

        // EDIT GET
        public IActionResult Edit(int id)
        {
            var p = _crud.GetPatient(id);
            return View(p);
        }

        // EDIT POST
        [HttpPost]
        public IActionResult Edit(Patient p)
        {
            _crud.UpdatePatient(p);
            return RedirectToAction("Index");
        }

        // DELETE
        public IActionResult Delete(int id)
        {
            _crud.DeletePatient(id);
            return RedirectToAction("Index");
        }
    }
}
