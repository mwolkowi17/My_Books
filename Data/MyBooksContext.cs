using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyBooks.Models;

namespace MyBooks.Models
{
    public class MyBooksContext : DbContext
    {
        public MyBooksContext (DbContextOptions<MyBooksContext> options)
            : base(options)
        {
        }

        public DbSet<MyBooks.Models.Book> Book { get; set; }

        public DbSet<MyBooks.Models.Cd> Cd { get; set; }

        public DbSet<MyBooks.Models.Film> Film { get; set; }

        

        
    }
}
