using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VivesBlog.Models
{
    public class Person
    {
        public Person()
        {
            AuthorArticles = new List<Article>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public IList<Article> AuthorArticles { get; set; }
    }
}
