using Domain.Contract;
using Domain.Entittes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.ApplicationService
{
    public class CellphoneService : ICellphoneService
    {
        private readonly ICellphoneRepository cellphoneRepository;
        public CellphoneService(ICellphoneRepository cellphoneRepository)
        {
            this.cellphoneRepository = cellphoneRepository;
        }
        public (List<Cellphone>, int Count) CellphoneSearch(string q, string Cellphonecategory, int CellphonepageNumber, int CellphonePageSize)
        {
            return cellphoneRepository.GetFilterCellphones(q, Cellphonecategory, CellphonepageNumber, CellphonePageSize);
        }

        public Cellphone Get(int CellphoneId)
        {
            throw new NotImplementedException();
        }

        public List<Cellphone> GetChippsetCellphone()
        {
            return cellphoneRepository.GetChippsetCellphone().ToList();
        }

        public List<Cellphone> GetNewstCellphone()
        {
            throw new NotImplementedException();
        }
    }
}
