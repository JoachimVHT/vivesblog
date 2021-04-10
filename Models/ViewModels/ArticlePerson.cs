using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VivesBlog.Models.ViewModels
{
    public class ArticlePerson
    {
        public Article Article { get; set; }
        public IList<Person> Authors { get; set; }
    }
}
