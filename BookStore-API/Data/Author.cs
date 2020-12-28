using BookStore_API.DTOs;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore_API.Data
{
    [Table("Authors")]
    public partial class Author
    {
        public int id { get; set; }

        public string FirstName { get; set; }

        public string  LastName { get; set; }

        public string Bio { get; set; }

        //for this author class we have called list of books,  because to get the data for author have list books
        public virtual IList<Book> Books { get; set; }
    }
}