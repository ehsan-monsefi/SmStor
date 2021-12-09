using Domain.Entittes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Contract
{
    public interface IProductService
    {
        Product Get(int ProductId);
        (List<Product>, int Count) ProductSearch(string q, string category, int pageNumber, int PageSize);
        List<Product> GetChippsetProduct();
        List<Product> GetNewstProduct();
    }
}
