using System;
using WebShop.DAL.Models;

namespace WebShop.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<CategoryEntity> Categorys { get; }
        IGenericRepository<CharacteristicEntity> Characteristics { get; }
        IGenericRepository<CompletedOrderEntity> CompletedOrders { get; }
        IGenericRepository<CompletedOrderDetailEntity> CompletedOrderDetails { get; }
        IGenericRepository<DescriptionEntity> Descriptions { get; }
        IGenericRepository<ImageEntity> Images { get; }
        IGenericRepository<OrderDetailEntity> OrderDetails { get; }
        IGenericRepository<OrderEntity> Orders { get; }
        IGenericRepository<ProductEntity> Products { get; }
        IGenericRepository<ReviewEntity> Reviews { get; }
        IGenericRepository<User> Users { get; }
    }
}
