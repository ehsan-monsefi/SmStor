using System.Collections.Generic;

namespace Domain.Entittes
{
    public class CellphoneCategory
    {
        public int CellphoneCategoryId { get; set; }
        public string CellphoneCategoryName { get; set; }
        public List<Cellphone> Cellphones { get; set; }
    }
}
