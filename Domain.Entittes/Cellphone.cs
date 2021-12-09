using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entittes
{
    public class Cellphone
    {
        public int CellphoneID { get; set; }
        public string CellphoneName { get; set; }
        public string CellphoneDescription { get; set; }
        public int CellphonePrice { get; set; }
        public CellphoneCategory CellphoneCategory { get; set; }
        public List<CellphoneMedia> CellphoneMedia { get; set; }
        public DateTime CellphoneInsertTime { get; set; }
    }
}
