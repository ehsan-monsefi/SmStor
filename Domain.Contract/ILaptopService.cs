using Domain.Entittes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Contract
{
    public interface ILaptopService
    {
        Laptop Get(int LaptopId);
        (List<Laptop>, int Count) LaptopSearch(string q, string laptopcategory, int laptoppageNumber, int laptopPageSize);
        List<Laptop> GetChippsetLaptop();
        List<Laptop> GetNewstLaptop();
    }
}

