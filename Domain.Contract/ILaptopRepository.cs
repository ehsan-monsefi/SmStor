using Domain.Entittes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Contract
{
    public interface ILaptopRepository
    {
        Laptop Get(int LaptopId);
        (List<Laptop>, int Count) GetFilterLaptops(string laptopsearch, string laptopcategory, int laptoppageNumber, int laptopPageSize);
        List<Laptop> GetChippsetLaptop();
        List<Laptop> GetNewstLaptop();
    }
}
