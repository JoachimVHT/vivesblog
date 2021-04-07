using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VivesBlog.Models;

namespace VivesBlog.Core
{
    public class Database : IDatabase
    {
        public IList<Article> Articles { get; set; }
        public IList<Person> People { get; set; }

        public Database()
        {
            Articles = new List<Article>();
            People = new List<Person>();
        }

        public void Initialize()
        {
            var person1 = new Person { Id = 1, FirstName = "Bavo", LastName = "Ketels" };
            People.Add(person1);
            var person2 = new Person { Id = 2, FirstName = "Joachim", LastName = "Van haecht" };
            //Toevoegen aan de People collection
            People.Add(person2);

            var article1 = new Article
            {
                Id = 1,
                Title = "Eerste artikel",
                Description =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam erat urna, dapibus sit amet tortor in, placerat venenatis dolor. Phasellus placerat auctor dui, non ornare dolor volutpat vitae. Phasellus sed dui massa. Etiam in lobortis quam. Praesent ultrices urna non posuere viverra. Suspendisse auctor magna lorem, ac fermentum nibh vulputate quis. Sed vehicula lobortis lacus, tincidunt mattis odio. In tincidunt lacinia augue. Fusce quis dui ac sem porttitor pulvinar eget eget ipsum. Proin tristique luctus massa nec sollicitudin. Quisque volutpat placerat quam id tincidunt. Curabitur quam nunc, ullamcorper nec sapien in, feugiat gravida risus. Etiam feugiat dictum nisi a ultricies. In molestie, odio quis hendrerit porta, ipsum felis facilisis nibh, non vestibulum lorem urna non tortor.",
                Content =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam erat urna, dapibus sit amet tortor in, placerat venenatis dolor. Phasellus placerat auctor dui, non ornare dolor volutpat vitae. Phasellus sed dui massa. Etiam in lobortis quam. Praesent ultrices urna non posuere viverra. Suspendisse auctor magna lorem, ac fermentum nibh vulputate quis. Sed vehicula lobortis lacus, tincidunt mattis odio. In tincidunt lacinia augue. Fusce quis dui ac sem porttitor pulvinar eget eget ipsum. Proin tristique luctus massa nec sollicitudin. Quisque volutpat placerat quam id tincidunt. Curabitur quam nunc, ullamcorper nec sapien in, feugiat gravida risus. Etiam feugiat dictum nisi a ultricies. In molestie, odio quis hendrerit porta, ipsum felis facilisis nibh, non vestibulum lorem urna non tortor. Vestibulum sollicitudin tortor ac cursus hendrerit. Pellentesque laoreet diam nec justo dignissim fringilla. Vivamus eget tellus eget risus pellentesque venenatis. Nulla sollicitudin metus ut turpis lacinia, eu condimentum dui malesuada. Ut sed iaculis mauris, nec laoreet felis. Vestibulum interdum ante at tristique lacinia. Maecenas ultrices erat sed neque viverra pellentesque. Sed ac nibh ac nibh elementum lacinia. Sed efficitur vitae mauris sit amet tristique. Ut aliquet malesuada tempor. Vivamus quis urna id lorem dictum consequat. Fusce ac rutrum purus. Donec lacinia imperdiet quam ut sodales. Vestibulum accumsan tempus lacus. Vestibulum sit amet aliquet nisl. Praesent pellentesque nunc eu risus sagittis tincidunt quis eget augue. Praesent faucibus sagittis tortor a aliquet. Cras lacus quam, ultricies id ipsum eget, vulputate porttitor risus. Duis et iaculis dolor.",
                Author = person1,
                AuthorId = person1.Id,
                CreatedDate = DateTime.Now
            };
            person1.AuthorArticles.Add(article1);

            var article2 = new Article
            {
                Id = 2,
                Title = "Tweede artikel",
                Description =
                    "Fusce felis diam, gravida eu gravida sed, fermentum in leo. Proin id tristique elit. Nulla at tortor at ligula placerat volutpat. Aliquam vehicula aliquet feugiat. Vivamus egestas purus convallis massa tempus vestibulum. Fusce mollis cursus risus egestas mollis. Vivamus quis hendrerit neque. Nunc in finibus nisi. Donec euismod maximus justo, euismod facilisis arcu interdum et.",
                Content =
                    "Fusce felis diam, gravida eu gravida sed, fermentum in leo. Proin id tristique elit. Nulla at tortor at ligula placerat volutpat. Aliquam vehicula aliquet feugiat. Vivamus egestas purus convallis massa tempus vestibulum. Fusce mollis cursus risus egestas mollis. Vivamus quis hendrerit neque. Nunc in finibus nisi. Donec euismod maximus justo, euismod facilisis arcu interdum et. Nulla vel ex nibh. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Phasellus pellentesque nisl sed justo mattis pharetra. Mauris finibus luctus magna, ac dapibus lacus varius non. Pellentesque risus leo, tristique vitae tortor eu, laoreet lobortis elit. Nunc aliquam odio sed eleifend ultrices. Nunc commodo sagittis enim, at porta eros ultrices sed. Curabitur sed eros volutpat, aliquet nulla vitae, ornare dolor. Curabitur et purus mauris. Donec quis auctor urna. Integer varius consectetur consequat. Cras tempor nunc ac felis euismod condimentum.",
                Author = person2,
                AuthorId = person2.Id,
                CreatedDate = DateTime.Now
            };
            person2.AuthorArticles.Add(article2);

            Articles = new List<Article>
            {
                article1,
                article2
            };
        }
    }
}