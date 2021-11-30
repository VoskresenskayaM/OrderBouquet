using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OrderBouquet.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace OrderBouquet.Controllers
{
    public class HomeController : Controller
    {
    
        private BouquetContext db;
        public HomeController(BouquetContext context)
        {
            db = context;
        }
 

        public IActionResult Index()
        {
            return View(db.Bouquets.ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bouquet = await db.Bouquets
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bouquet == null)
            {
                return NotFound();
            }

            return View(bouquet);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
