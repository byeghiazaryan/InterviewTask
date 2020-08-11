using InterviewTask.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTask.Services
{
    public class ServiceBase
    {
        protected readonly IUnitOfWork unitOfWork;
        public ServiceBase(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
    }
}
