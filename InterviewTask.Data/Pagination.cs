using InterviewTask.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTask.Data.Paging
{
    /// <summary>
    /// Type, for support pagination in entities level
    /// </summary>
    public class Pagination
    {
        public Pagination()
        {
            Page = new PageData();
            Sort = new SortData();
        }
        public int Count { get; set; }
        public PageData Page { get; set; }
        public SortData Sort { get; set; }
    }

    public class SortData
    {
        public string Member { get; set; } = "Id";
        public Sorting? Direction { get; set; } = Sorting.DESC;
    }
    public class PageData
    {
        public int Number { get; set; }
        public int Size { get; set; } = 5;
    }
}
