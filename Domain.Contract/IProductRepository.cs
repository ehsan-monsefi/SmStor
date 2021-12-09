using Domain.Entittes;
using System;
using System.Collections.Generic;

namespace Domain.Contract
{
    public interface IProductRepository
    {
        Product Get(int ProductId);
        (List<Product>, int Count) GetFilterProducts(string search, string category, int pageNumber, int PageSize);
        List<Product> GetChippsetProduct();
        List<Product> GetNewstProduct();
    }
}
