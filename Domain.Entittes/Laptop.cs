using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entittes
{
    public class Laptop
    {
        public int LaptopID { get; set; }
        public string LaptopName { get; set; }
        public string LaptopDescription { get; set; }
        public int LaptopPrice { get; set; }
        public LaptopCategory LaptopCategory { get; set; }
        public List<LaptopMedia> LaptopMedia { get; set; }
        public DateTime LaptopInsertTime { get; set; }
    }
}
