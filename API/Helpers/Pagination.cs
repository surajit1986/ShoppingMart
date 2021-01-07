using System.Collections.Generic;

namespace API.Helpers
{
    public class Pagination<T> where T: class
    {
        public Pagination(int pageIndex, int pageCount, int count, IReadOnlyList<T> data)
        {
            PageIndex = pageIndex;
            PageCount = pageCount;
            Count = count;
            Data = data;
        }

        public int PageIndex { get; set; }
        public int PageCount { get; set; }
        public int Count { get; set; }
        public IReadOnlyList<T> Data { get; set; }
    }
}