using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebShop.DAL.Models;

namespace WebShop.DAL.DataAccses
{
    public class DataAccsess : IdentityDbContext<User>
    {
        public DataAccsess(DbContextOptions<DataAccsess> options) : base(options) { Database.EnsureCreated(); }
        public DbSet<ReviewEntity> Reviews { get; set; }
        public DbSet<DescriptionEntity> Discriptions { get; set; }
        public DbSet<OrderDetailEntity> OrderDetails { get; set; }
        public DbSet<CompletedOrderEntity> completedOrders { get; set; }
        public DbSet<CompletedOrderDetailEntity> CompletedOrderDetails { get; set; }
        public DbSet<CharacteristicEntity> Characteristics { get; set; }
        public DbSet<ProductEntity> Product { get; set; }
        public DbSet<ImageEntity> Images { get; set; }
        public DbSet<OrderEntity> Orders { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }

    }
}
