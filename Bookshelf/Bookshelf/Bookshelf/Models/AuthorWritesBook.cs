using SQLiteNetExtensions.Attributes;

namespace Bookshelf
{
    public class AuthorWritesBook
    {
        [ForeignKey(typeof(Author))]
        public int AuthorId { get; set; }

        [ForeignKey(typeof(Book))]
        public int BookId { get; set; }
    }
}