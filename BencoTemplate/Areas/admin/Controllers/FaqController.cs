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
         

    }
}
