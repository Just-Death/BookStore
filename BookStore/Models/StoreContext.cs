using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class StoreContext: DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Order> Orders { get; set; }
        public StoreContext(DbContextOptions<StoreContext> options)
        : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
