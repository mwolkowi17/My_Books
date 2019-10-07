using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyBooks.Models
{
    public class MyBooksContext : DbContext
    {
        public MyBooksContext (DbContextOptions<MyBooksContext> options)
            : base(options)
        {
        }

        public DbSet<MyBooks.Models.Book> Book { get; set; }
    }
}
