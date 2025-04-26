using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Application
{
    public class QueryParameter
    {
        public class PagedResult<T>
        {
            public IEnumerable<T> Items { get; set; }
            public int PageNumber { get; set; }
            public int PageSize { get; set; }
            public int TotalCount { get; set; }
            public int TotalPages =>
                (int)Math.Ceiling(TotalCount / (double)PageSize);
        }

        public class HolidayQueryParameters
        {
            const int _maxPageSize = 100;
            private int _pageSize = 10;

            public int PageNumber { get; set; } = 1;
            public int PageSize
            {
                get => _pageSize;
                set => _pageSize = (value > _maxPageSize)
                                    ? _maxPageSize
                                    : value;
            }

            /// e.g. "Name", "FromDate", "ToDate"
            public string SortBy { get; set; }
            public bool SortDesc { get; set; }

            /// free‐text search on name
            public string Search { get; set; }
            public string Country { get; set; }
            public bool? OnlyActive { get; set; }
        }
    }
}
