using Microsoft.EntityFrameworkCore;

namespace BookstoreApp.Models
{
    
        public class BookStoreContext : DbContext
        {
            public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options)
            {
            }

            public DbSet<User> Users { get; set; }
            public DbSet<InventoryItem> Inventory { get; set; }
            public DbSet<CartItem> CartItems { get; set; }
        }
    
}
