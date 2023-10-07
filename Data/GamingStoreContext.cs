using System;
using Microsoft.EntityFrameworkCore;

namespace Gaming_Store.Data
{
    public class GamingStoreContext : DbContext
    {
        public GamingStoreContext(DbContextOptions<GamingStoreContext> options)
             : base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }
        
    }
}
