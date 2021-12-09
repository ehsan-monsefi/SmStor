using Domain.Contract;
using Domain.Entittes;
using Infrastructure.Sql;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly SmContext context;
        public ProductRepository(SmContext context)
        {
            this.context = context;
        }
        public Product Get(int ProductId)
        {
            return context.Products.Include(a => a.Media).First(a => a.ProductID == ProductId);
        }

        public List<Product> GetChippsetProduct()
        {
            return context.Products.Include(a => a.Media).OrderByDescending(a => a.InsertTime).ToList();
        }

        public (List<Product>, int Count) GetFilterProducts(string search, string category, int pageNumber, int PageSize)
        {
            IQueryable<Product> query = context.Products.Include(a => a.Media);
            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(a => a.Name.Contains(search) || a.Description.Contains(search));
            }
            if (category != "All")
            {
                query = query.Where(a => a.Category.CategoryName == category);
            }
            var lengthQuery = query.ToList().Count;
            return (query.Skip((pageNumber - 1) * PageSize).Take(PageSize).ToList(), lengthQuery);
        }

        public List<Product> GetNewstProduct()
        {
            return context.Products.Include(a => a.Media).OrderByDescending(a => a.InsertTime).ToList();
        }
    }
}
