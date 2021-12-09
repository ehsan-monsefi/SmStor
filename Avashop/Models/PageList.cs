using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avashop.Models
{
    public class PageList<T>
    {
        public int CurrentPage { get; private set; }
        public int TotalPages { get; private set; }
        public int PageSize { get; private set; }
        public int TotalCount { get; private set; }
        public List<T> Data { get; private set; }
        public PageList(List<T> item, int pageNumber, int pageSize, int total)
        {
            TotalCount = total;
            PageSize = pageSize;
            CurrentPage = pageNumber;
            TotalPages = (int)Math.Ceiling(total / (double)pageSize);
            Data = item;
        }
    }
}
