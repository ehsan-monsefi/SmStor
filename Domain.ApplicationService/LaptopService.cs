using Domain.Contract;
using Domain.Entittes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.ApplicationService
{
    public class LaptopService : ILaptopService
    {
        private readonly ILaptopRepository laptopRepository;
        public LaptopService(ILaptopRepository laptopRepository)
        {
            this.laptopRepository = laptopRepository;
        }

        public Laptop Get(int LaptopId)
        {
            throw new NotImplementedException();
        }

        public List<Laptop> GetChippsetLaptop()
        {
            return laptopRepository.GetChippsetLaptop().ToList();
        }

        public List<Laptop> GetNewstLaptop()
        {
            throw new NotImplementedException();
        }

        public (List<Laptop>, int Count) LaptopSearch(string q, string laptopcategory, int laptoppageNumber, int laptopPageSize)
        {
            return laptopRepository.GetFilterLaptops(q, laptopcategory, laptoppageNumber, laptopPageSize);
        }
    }
}
