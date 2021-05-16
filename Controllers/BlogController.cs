using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VivesBlog.Core;
using VivesBlog.Models;
using VivesBlog.Models.ViewModels;

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

        [HttpGet]
        public IActionResult Create()
        {
            var authors = _database.People;

            var articleModel = new ArticlePerson
            {
                Authors = authors
            };
            return View(articleModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Article article)
        {
            article.Id = GetNewId();
            article.CreatedDate = DateTime.UtcNow;
            _database.Articles.Add(article);

            var dbAuthor = _database.People.SingleOrDefault(p => p.Id == article.AuthorId);
            if (dbAuthor == null)
            {
                return RedirectToAction("Index");
            }
            article.Author = dbAuthor;

            dbAuthor.AuthorArticles.Add(article);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var article = _database.Articles.SingleOrDefault(a => a.Id == id);

            if (article == null)
            {
                return RedirectToAction("Index");
            }

            var authors = _database.People;
            var articleModel = new ArticlePerson
            {
                Article = article,
                Authors = authors
            };

            return View(articleModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Article article)
        {
            var dbArticle = _database.Articles.SingleOrDefault(p => p.Id == article.Id);

            if (dbArticle == null)
            {
                return RedirectToAction("Index");
            }

            dbArticle.Title = article.Title;
            dbArticle.Description = article.Description;
            dbArticle.Content = article.Content;
            dbArticle.AuthorId = article.AuthorId;

            var dbAuthor = _database.People.SingleOrDefault(p => p.Id == article.AuthorId);

            if (dbAuthor == null)
            {
                return RedirectToAction("Index");
            }

            dbArticle.Author = dbAuthor;

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var article = _database.Articles.SingleOrDefault(p => p.Id == id);

            if (article == null)
            {
                return RedirectToAction("Index");
            }

            return View(article);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Blog/Delete/{id?}")]
        public IActionResult DeleteConfirmed(int id)
        {
            var article = _database.Articles.SingleOrDefault(a => a.Id == id);

            if (article == null)
            {
                return RedirectToAction("Index");
            }

            _database.Articles.Remove(article);

            return RedirectToAction("Index");
        }

        private int GetNewId()
        {
            if (_database.Articles.Any())
            {
                var getMaxId = _database.Articles.Max(p => p.Id);
                return getMaxId += 1;
            }
            else
            {
                return 1;
            }
        }
    }
}
