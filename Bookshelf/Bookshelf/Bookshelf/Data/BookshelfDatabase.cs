using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bookshelf
{
    public class BookshelfDatabase
    {
        private readonly SQLiteAsyncConnection _database;

        public BookshelfDatabase(string databasePath)
        {
            _database = new SQLiteAsyncConnection(databasePath);
            CreateTables(_database);
        }

        private void CreateTables(SQLiteAsyncConnection database)
        {
            database.CreateTableAsync<AuthorWritesBook>().Wait();
            database.CreateTableAsync<Author>().Wait();
            database.CreateTableAsync<Category>().Wait();
            database.CreateTableAsync<Book>().Wait();
        }

        #region Author methods
        public Task<List<Author>> GetAuthorsAsync()
        {
            return _database.Table<Author>().ToListAsync();
        }

        public Task<Author> GetAuthorAsync(int id)
        {
            return _database.Table<Author>().
                Where(author => author.Id == id).
                FirstAsync();
        }

        public Task<int> SaveAuthorAsync(Author author)
        {
            if (author.Id == 0)
                return _database.InsertAsync(author);
            return _database.UpdateAsync(author);
        }

        public Task<int> DeleteAuthorAsync(Author author)
        {
            return _database.DeleteAsync(author);
        }
        #endregion

        #region Category methods
        public Task<List<Category>> GetCategoriesAsync()
        {
            return _database.Table<Category>().ToListAsync();
        }

        public Task<Category> GetCategoryAsync(int id)
        {
            return _database.Table<Category>().
                Where(category => category.Id == id).
                FirstAsync();
        }

        public Task<int> SaveCategoryAsync(Category category)
        {
            if (category.Id == 0)
                return _database.InsertAsync(category);
            return _database.UpdateAsync(category);
        }

        public Task<int> DeleteCategoryAsync(Category category)
        {
            return _database.DeleteAsync(category);
        }
        #endregion

        #region Book methods
        public Task<List<Book>> GetBooksAsync()
        {
            return _database.Table<Book>().ToListAsync();
        }

        public Task<Book> GetBookAsync(int id)
        {
            return _database.Table<Book>().
                Where(book => book.Id == id).
                FirstAsync();
        }

        public Task<int> SaveBookAsync(Book book)
        {
            if (book.Id == 0)
                return _database.InsertAsync(book);
            return _database.UpdateAsync(book);
        }

        public Task<int> DeleteBookAsync(Book book)
        {
            return _database.DeleteAsync(book);
        }
        #endregion
    }
}