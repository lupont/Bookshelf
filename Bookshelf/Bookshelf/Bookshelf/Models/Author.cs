using SQLite;
using SQLiteNetExtensions.Attributes;
using System.Collections.Generic;

namespace Bookshelf
{
    public class Author
    {
        [PrimaryKey, AutoIncrement]
        public int        Id        { get; set; }

        [ManyToMany(typeof(AuthorWritesBook))]
        public List<Book> Books { get; set; }

        public string     FirstName { get; set; }
        public string     LastName  { get; set; }
    }
}