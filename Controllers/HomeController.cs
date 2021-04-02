using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using VivesBlog.Models;

namespace VivesBlog.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var articles = getArticleLijst();
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

        public List<Article> getArticleLijst()
        {
            return new List<Article>
            {
                new Article{Id=1, AuthorFirstName="joachim", AuthorId=1, AuthorLastName="sanctorum", Content="blaabl blablabl ablabl", Description="blabla", Title="eerste post"},
                new Article{Id=2, AuthorFirstName="joachim", AuthorId=1, AuthorLastName="sanctorum", Content="blaabl blablabl ablabl", Description="blabla", Title="tweede post"},
                new Article{Id=2, AuthorFirstName="joachim", AuthorId=1, AuthorLastName="sanctorum", Content="blaabl blablabl ablabl", Description="blabla", Title="derde post"}
            };
        }
        public IActionResult Read(int id)
        {
            var articles = getArticleLijst();
            var article = articles.SingleOrDefault(a => a.Id == id);
            if (article == null)
                return RedirectToAction("Index");

            return View(article);
        }
    }
}
