using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VivesBlog.Models;

namespace VivesBlog.Core
{
    public interface IDatabase
    {
        IList<Article> Articles { get; set; }
        IList<Person> People { get; set; }
        
        void Initialize();

    }
}
