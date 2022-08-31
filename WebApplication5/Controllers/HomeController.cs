using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
      

        private news_dbcontext db;
        public HomeController(news_dbcontext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
           var resulte= db.catogries.ToList();
            return View(resulte);
        }
        public IActionResult contact_us()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Savecontact(contact_us modle)
        {
            db.contact_us.Add(modle);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult reviwe()
        {
            return View(db.contact_us.ToList());
        }
        public IActionResult news(int id)
        {
            var resulte = db.news.Where(x => x.catogryId == id).ToList();
            return View(resulte);
        }
        public IActionResult About()
        {
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
