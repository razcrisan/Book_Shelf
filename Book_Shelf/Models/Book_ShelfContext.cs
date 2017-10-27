using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Book_Shelf.Models
{
    public class Book_ShelfContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Book_ShelfContext() : base("name=Book_ShelfContext")
        {
        }

        public System.Data.Entity.DbSet<Book_Shelf.Models.Book> Books { get; set; }

        public System.Data.Entity.DbSet<Book_Shelf.Models.Category> Categories { get; set; }
    }
}
