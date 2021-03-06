﻿using SportsStore.Domain.Entities;
using SportsStore.Domain.Abstract;
using System.Linq;

namespace SportsStore.Domain.Concrete
{
    public class EFProductsRepository : IProductRepository
    {
        private EFDbContext context = new EFDbContext();

        public IQueryable<Product> Products
        {
            get { return context.Products; }
        }
    }
}
