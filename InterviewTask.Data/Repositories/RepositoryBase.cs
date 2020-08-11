using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTask.Data.Repositories
{
    public class RepositoryBase
    {
        protected readonly ApplicationDBContext dbContext;
        public RepositoryBase(ApplicationDBContext dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
