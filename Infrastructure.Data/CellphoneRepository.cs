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
    public class CellphoneRepository : ICellphoneRepository
    {
        private readonly SmContext context;
        public CellphoneRepository(SmContext context)
        {
            this.context = context;
        }
        public Cellphone Get(int CellphoneId)
        {
            return context.Cellphones.Include(a => a.CellphoneMedia).First(a => a.CellphoneID == CellphoneId);
        }

        public List<Cellphone> GetChippsetCellphone()
        {
            return context.Cellphones.Include(a => a.CellphoneMedia).OrderByDescending(a => a.CellphoneInsertTime).ToList();
        }

        public (List<Cellphone>, int Count) GetFilterCellphones(string Cellphonesearch, string Cellphonecategory, int CellphonepageNumber, int CellphonePageSize)
        {
            IQueryable<Cellphone> query = context.Cellphones.Include(a => a.CellphoneMedia);
            if (!string.IsNullOrEmpty(Cellphonesearch))
            {
                query = query.Where(a => a.CellphoneName.Contains(Cellphonesearch) || a.CellphoneDescription.Contains(Cellphonesearch));
            }
            if (Cellphonecategory != "All")
            {
                query = query.Where(a => a.CellphoneCategory.CellphoneCategoryName == Cellphonecategory);
            }
            var lengthQuery = query.ToList().Count;
            return (query.Skip((CellphonepageNumber - 1) * CellphonePageSize).Take(CellphonePageSize).ToList(), lengthQuery);
        }

        public List<Cellphone> GetNewstCellphone()
        {
            throw new NotImplementedException();
        }
    }
}
