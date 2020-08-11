using InterviewTask.Data.Paging;
using InterviewTask.Models.Filtering;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTask.Data.Repositories
{
    interface IRepository<TEntity> where TEntity : class
    {
        Task<TEntity> Get(int id);
        IQueryable<TEntity> Get(int[] ids);
        IQueryable<TEntity> GetAll(Pagination pagination, Filter filter);
        Task<TEntity> Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);
    }
}
