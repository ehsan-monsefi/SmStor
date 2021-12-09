using Domain.Entittes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Contract
{
    public interface ICellphoneRepository
    {
        Cellphone Get(int CellphoneId);
        (List<Cellphone>, int Count) GetFilterCellphones(string Cellphonesearch, string Cellphonecategory, int CellphonepageNumber, int CellphonePageSize);
        List<Cellphone> GetChippsetCellphone();
        List<Cellphone> GetNewstCellphone();
    }
}
