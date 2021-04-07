using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using VivesBlog.Core;
using VivesBlog.Models;

namespace VivesBlog.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private readonly IDatabase _database;

        public HomeController(ILogger<HomeController> logger, IDatabase database)
        {
            _logger = logger;
            _database = database;
        }

        public IActionResult Index()
        {
            var articles = _database.Articles;
            return View(articles);
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

        
        public IActionResult Read(int id)
        {
            var articles = _database.Articles;
            var article = articles.SingleOrDefault(a => a.Id == id);
            if (article == null)
                return RedirectToAction("Index");

            return View(article);
        }
    }
}
