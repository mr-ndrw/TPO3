using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace TPO3WebApi.Models
{
    public class BookstoreContext : DbContext
    {

        public BookstoreContext(string connectionString) : base(connectionString)
        {
            

        }

        public class Book
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Isbn { get; set; }

            public virtual List<Author> Authors { get; set; }
            public virtual List<Category> Categories { get; set; }
            public virtual List<Review> Reviews { get; set; }
        }

        public class Author
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Content { get; set; }

            public virtual List<Book> Books { get; set; } 
        }

        public class Category
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public virtual List<Book> BooksOfThatCategory { get; set; }\
        }

        public class Review
        {
            public int Id { get; set; }
            public string AuthorName { get; set; }
            public string Title { get; set; }

            public int BookId { get; set; }
            public Book Book { get; set; }
        }

    }
}
