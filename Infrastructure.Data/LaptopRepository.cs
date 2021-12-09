using Domain.Contract;
using Domain.Entittes;
using Infrastructure.Sql;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Data
{
    public class LaptopRepository : ILaptopRepository
    {
        private readonly SmContext context;
        public LaptopRepository(SmContext context)
        {
            this.context = context;
        }
        public Laptop Get(int LaptopId)
        {
            return context.Laptops.Include(a => a.LaptopMedia).First(a => a.LaptopID == LaptopId);
        }

        public List<Laptop> GetChippsetLaptop()
        {
            return context.Laptops.Include(a => a.LaptopMedia).OrderByDescending(a => a.LaptopInsertTime).ToList();
        }

        public (List<Laptop>, int Count) GetFilterLaptops(string laptopsearch, string laptopcategory, int laptoppageNumber, int laptopPageSize)
        {
            IQueryable<Laptop> query = context.Laptops.Include(a => a.LaptopMedia);
            if (!string.IsNullOrEmpty(laptopsearch))
            {
                query = query.Where(a => a.LaptopName.Contains(laptopsearch) || a.LaptopDescription.Contains(laptopsearch));
            }
            if (laptopcategory != "All")
            {
                query = query.Where(a => a.LaptopCategory.LaptopCategoryName == laptopcategory);
            }
            var lengthQuery = query.ToList().Count;
            return (query.Skip((laptoppageNumber - 1) * laptopPageSize).Take(laptopPageSize).ToList(), lengthQuery);
        }

        public List<Laptop> GetNewstLaptop()
        {
            return context.Laptops.Include(a => a.LaptopMedia).OrderByDescending(a => a.LaptopInsertTime).ToList();
        }
    }
}
