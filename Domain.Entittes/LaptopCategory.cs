using System.Collections.Generic;

namespace Domain.Entittes
{
    public class LaptopCategory
    {
        public int LaptopCategoryId { get; set; }
        public string LaptopCategoryName { get; set; }
        public List<Laptop> Laptop { get; set; }
    }
}
