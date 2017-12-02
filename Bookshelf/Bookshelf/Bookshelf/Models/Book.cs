using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;

namespace Bookshelf
{
    public class Book
    {
        [PrimaryKey, AutoIncrement]
        public int            Id                  { get; set; }

        [ManyToMany(typeof(AuthorWritesBook))]
        public List<Author>   Authors             { get; set; }

        [OneToMany]
        public List<Category> Categories          { get; set; }

        public string         Title               { get; set; }
        public string         Description         { get; set; }
        public DateTime       StartedReadingDate  { get; set; }
        public DateTime       FinishedReadingDate { get; set; }
        public int            CurrentPage         { get; set; }
        public Rating         Rating              { get; set; }
    }
}