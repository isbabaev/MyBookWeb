using Microsoft.EntityFrameworkCore;
using MyBook.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBook.Core.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) {
        }

        public DbSet<Book> Books { get; set; }
    }
}
