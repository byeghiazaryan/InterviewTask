using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTask.Data.Repositories
{
    //INFO: Following to S.O.L.I.D' ("I" principle): Interface segregation
    //IListRepository separated from IRepository
    //For not force Repositories to implement for them sometimes unnecessary methods 
    //For satisfy to interface signature.
    public interface IRangeRepository<TEntity> where TEntity : class
    {
        Task AddRangeAsync(IEnumerable<TEntity> entities);
        void RemoveRange(IEnumerable<TEntity> entities);
        void UpdateRange(IEnumerable<TEntity> entities);
    }
}
