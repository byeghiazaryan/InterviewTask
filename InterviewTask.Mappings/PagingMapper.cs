using AutoMapper;
using InterviewTask.Data.Paging;
using InterviewTask.Models.Paging;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTask.Mappings
{
    public class PagingMapper:Profile
    {
        public PagingMapper()
        {
            CreateMap<PagingModel, Pagination>();
        }
    }
}
