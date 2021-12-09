using Domain.Contract;
using Domain.Entittes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.ApplicationService
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;
        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public Product Get(int ProductId)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetChippsetProduct()
        {
            return productRepository.GetChippsetProduct().ToList();
        }

        public List<Product> GetNewstProduct()
        {
            throw new NotImplementedException();
        }

        public (List<Product>, int Count) ProductSearch(string q, string category, int pageNumber, int PageSize)
        {
            return productRepository.GetFilterProducts(q, category, pageNumber, PageSize);
        }
    }
}
