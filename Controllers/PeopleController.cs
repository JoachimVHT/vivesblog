using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VivesBlog.Core;
using VivesBlog.Models;

namespace VivesBlog.Controllers
{
    public class PeopleController : Controller
    {
        private readonly IDatabase _database;

        public PeopleController(IDatabase database)
        {
            _database = database;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var people = GetPeople();
            return View(people);
        }

        public IList<Person> GetPeople()
        {
            return _database.People;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Person person)
        {
            person.Id = GetNewId();
            _database.People.Add(person);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var person = _database.People.SingleOrDefault(p => p.Id == id);

            if (person == null)
            {
                return RedirectToAction("Index");
            }

            return View(person);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Person person)
        {
            var dbPerson = _database.People.SingleOrDefault(p => p.Id == person.Id);

            if (dbPerson == null)
            {
                return RedirectToAction("Index");
            }

            dbPerson.FirstName = person.FirstName;
            dbPerson.LastName = person.LastName;

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var person = _database.People.SingleOrDefault(p => p.Id == id);

            if (person == null)
            {
                return RedirectToAction("Index");
            }

            return View(person);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("People/Delete/{id?}")]
        public IActionResult DeleteConfirmed(int id)
        {
            var person = _database.People.SingleOrDefault(p => p.Id == id);

            if (person == null)
            {
                return RedirectToAction("Index");
            }

            _database.People.Remove(person);

            return RedirectToAction("Index");
        }

        private int GetNewId()
        {
            if (_database.People.Any())
            {
                var getMaxId = _database.People.Max(p => p.Id);
                return getMaxId += 1;
            }
            else
            {
                return 1;
            }
        }
    }
}