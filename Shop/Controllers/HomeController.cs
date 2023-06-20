using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Shop.Data;
using Shop.Models;

namespace Shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(string searchString, int? CategoryId=null)
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "FullTitle");

            if (_context.Items == null)
            {
                return BadRequest(" در پردازش اطلاعات خطایی رخ داده است");
            }

            var items = from m in _context.Items
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                items = items.Where(s => s.Title.Contains(searchString));
            }

            if (CategoryId != null)
            {
                items = items.Where(s => s.CategoryId == CategoryId);
            }

            return View(items.ToList());
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
