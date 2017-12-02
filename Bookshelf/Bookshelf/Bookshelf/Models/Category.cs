using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Bookshelf
{
    public class Category
    {
        [PrimaryKey, AutoIncrement]
        public int    Id     { get; set; }

        [ForeignKey(typeof(Book))]
        public int    BookId { get; set; }
        public string Name   { get; set; }
    }
}