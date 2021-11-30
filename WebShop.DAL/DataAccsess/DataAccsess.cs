using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebShop.DAL.Models;

namespace WebShop.DAL.DataAccsess
{
    public class DataAccsess : IdentityDbContext<User>
    {
        public DataAccsess(DbContextOptions<DataAccsess> options) : base(options) { Database.EnsureCreated(); }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Discription> Discriptions { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<CompletedOrder> completedOrders { get; set; }
        public DbSet<CompletedOrderDetail> CompletedOrderDetails { get; set; }
        public DbSet<Characteristic> Characteristics { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
