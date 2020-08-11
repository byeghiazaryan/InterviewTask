using InterviewTask.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTask.Models.Paging
{
    public class PagingModel
    {
        public PagingModel()
        {
            Page = new PageData();
            Sort = new SortData();
        }
        public int Count { get; set; } = 5;
        public PageData Page { get; set; }
        public SortData Sort { get; set; }
    }

    public class SortData
    {
        public string Member { get; set; } = "id";
        public Sorting? Direction { get; set; } = Sorting.ASC;
    }
    public class PageData
    {
        public PageData()
        {
            Number = 0;
            Size = 5;
        }
        public int Number { get; set; }
        public int Size { get; set; }
    }
}
