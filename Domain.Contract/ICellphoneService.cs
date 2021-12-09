using Domain.Entittes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Contract
{
    public interface ICellphoneService
    {
        Cellphone Get(int CellphoneId);
        (List<Cellphone>, int Count) CellphoneSearch(string q, string Cellphonecategory, int CellphonepageNumber, int CellphonePageSize);
        List<Cellphone> GetChippsetCellphone();
        List<Cellphone> GetNewstCellphone();
    }
}
