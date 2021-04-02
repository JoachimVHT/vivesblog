using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VivesBlog.Models;

namespace VivesBlog.Controllers
{
    public class BlogController : Controller
    {
       
       
        public IActionResult Index()
        {
            var articles = getArticleLijst();
            return View(articles);
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
    }
}
