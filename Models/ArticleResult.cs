using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VivesBlog.Models
{
    public class ArticleResult
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public int AuthorId { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
