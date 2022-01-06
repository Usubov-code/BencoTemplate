using BencoTemplate.Data;
using BencoTemplate.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BencoTemplate.Areas.admin.Controllers
{
    [Area("admin")]
    public class FaqController : Controller
    {
        private readonly AppDbContext _context;

        public FaqController(AppDbContext context)
        {
           _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Faqs.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(Faq model )
        {
            if (ModelState.IsValid)
            {
                _context.Faqs.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
           


            return View(model);
        }
        [HttpGet]

        public IActionResult Update (int? Id)
        {


            return View(_context.Faqs.Find(Id));

        }
        [HttpPost]
        public IActionResult Update(Faq model)
        {
            if (ModelState.IsValid)
            {
                _context.Faqs.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }



            return View(model);
        }
        public IActionResult Delete(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }
            Faq faq = _context.Faqs.Find(Id);
            if (faq == null)
            {
                return NotFound();
            }
            _context.Faqs.Remove(faq);
            _context.SaveChanges();
            return RedirectToAction("index");
           
        }
    }
}
