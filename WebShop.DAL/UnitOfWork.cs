using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShop.DAL.Interfaces;
using WebShop.DAL.Models;
using WebShop.DAL.DataAccses;
using WebShop.DAL.Repositories;

namespace WebShop.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataAccsess _appData;

        private GenericRepository<CategoryEntity> _categorys;
        private GenericRepository<CharacteristicEntity> _characteristics;
        private GenericRepository<CompletedOrderEntity> _completedOrders;
        private GenericRepository<CompletedOrderDetailEntity> _completedOrderDetails;
        private GenericRepository<DescriptionEntity> _descriptions;
        private GenericRepository<ImageEntity> _images;
        private GenericRepository<OrderEntity> _orders;
        private GenericRepository<OrderDetailEntity> _orderDetails;
        private GenericRepository<ProductEntity> _products;
        private GenericRepository<ReviewEntity> _reviews;
        private GenericRepository<User> _users;

        public UnitOfWork(DataAccsess appData)
        {
            _appData = appData;
        }

        public IGenericRepository<CategoryEntity> Categorys => _categorys ??= new GenericRepository<CategoryEntity>(_appData);

        public IGenericRepository<CharacteristicEntity> Characteristics => _characteristics ??= new GenericRepository<CharacteristicEntity>(_appData);

        public IGenericRepository<CompletedOrderEntity> CompletedOrders => _completedOrders ??= new GenericRepository<CompletedOrderEntity>(_appData);

        public IGenericRepository<CompletedOrderDetailEntity> CompletedOrderDetails => _completedOrderDetails ??= new GenericRepository<CompletedOrderDetailEntity>(_appData);

        public IGenericRepository<DescriptionEntity> Descriptions => _descriptions ??= new GenericRepository<DescriptionEntity>(_appData);

        public IGenericRepository<ImageEntity> Images => _images ??= new GenericRepository<ImageEntity>(_appData);

        public IGenericRepository<OrderDetailEntity> OrderDetails => _orderDetails ??= new GenericRepository<OrderDetailEntity>(_appData);

        public IGenericRepository<OrderEntity> Orders => _orders ??= new GenericRepository<OrderEntity>(_appData);

        public IGenericRepository<ProductEntity> Products => _products ??= new GenericRepository<ProductEntity>(_appData);

        public IGenericRepository<ReviewEntity> Reviews => _reviews ??= new GenericRepository<ReviewEntity>(_appData);

        public IGenericRepository<User> Users => _users ??= new GenericRepository<User>(_appData);

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _appData.Dispose();
                }
                this.disposed = true;
            }
        }

        void IDisposable.Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
