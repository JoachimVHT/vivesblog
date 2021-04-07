using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VivesBlog.Core;
using VivesBlog.Models;

namespace VivesBlog.Controllers
{
    public class BlogController : Controller
    {
        private readonly IDatabase _database;

       public BlogController(IDatabase database)
        {
            _database = database;
        }
        public IActionResult Index()
        {
            var articles = _database.Articles;
            return View(articles);
        }

       
    }
}
