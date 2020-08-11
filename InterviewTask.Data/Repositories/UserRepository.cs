using InterviewTask.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using InterviewTask.Data.Paging;
using InterviewTask.Data.Extensions;
using InterviewTask.Models.Filtering;

namespace InterviewTask.Data.Repositories
{
    public class UserRepository : RepositoryBase, IRepository<User>, IRangeRepository<User>
    {
        public UserRepository(ApplicationDBContext dbContext) : base(dbContext)
        {

        }

        public async Task AddRangeAsync(IEnumerable<User> entities)
        {
            await dbContext.AddRangeAsync(entities);
        }

        public async Task<User> Add(User item)
        {
            await dbContext.AddAsync(item);
            return item;
        }

        public void Remove(User user)
        {
            dbContext.Remove(user);
        }

        public async Task<User> Get(int id)
        {
            return await dbContext.User.AsNoTracking().Where(u => u.Id == id).FirstOrDefaultAsync();
        }

        public IQueryable<User> Get(int[] ids)
        {
            var usersQuery = dbContext.User.Where(u => ids.Contains(u.Id));

            return usersQuery;
        }

        public IQueryable<User> GetAll(Pagination pagination, Filter filter)
        {
            var usersQuery = dbContext.User as IQueryable<User>;

            if (filter.Id.HasValue)
                usersQuery = usersQuery.Where(item => item.Id == filter.Id);
            if (!string.IsNullOrWhiteSpace(filter.FirstName))
                usersQuery = usersQuery.Where(item => item.FirstName.ToLower().Contains(filter.FirstName.ToLower()));
            if (!string.IsNullOrWhiteSpace(filter.LastName))
                usersQuery = usersQuery.Where(item => item.LastName.ToLower().Contains(filter.LastName.ToLower()));
            if (!string.IsNullOrWhiteSpace(filter.Email))
                usersQuery = usersQuery.Where(item => item.Email.ToLower().Contains(filter.Email.ToLower()));
            if (!string.IsNullOrWhiteSpace(filter.Mobile))
                usersQuery = usersQuery.Where(item => item.Mobile.ToLower().Contains(filter.Mobile.ToLower()));
            if (filter.Age.HasValue)
                usersQuery = usersQuery.Where(item => item.Age == filter.Age);
            if (filter.Classification.HasValue && filter.Classification.Value!=0)
                usersQuery = usersQuery.Where(item => item.Classification == filter.Classification);
            if (filter.IsActive.HasValue)
                usersQuery = usersQuery.Where(item => item.IsActive == filter.IsActive);
            if (filter.CreatedDate.HasValue)
                usersQuery = usersQuery.Where(item => item.CreatedDate.Date == filter.CreatedDate);

            if (pagination != null)
            {
                //INFO: OrderByDynamic is custom written dynamic order by expression
                pagination.Count = usersQuery.Count();
                if (pagination.Sort.Direction != null && !string.IsNullOrEmpty(pagination.Sort.Member))
                {
                    usersQuery = usersQuery.OrderByDynamic(pagination.Sort.Member, pagination.Sort.Direction.Value);
                }
                usersQuery = usersQuery.Skip(pagination.Page.Number * pagination.Page.Size).Take(pagination.Page.Size);
            }
            return usersQuery;
        }

        public void RemoveRange(IEnumerable<User> users)
        {
            dbContext.RemoveRange(users);
        }

        public void Update(User user)
        {
            dbContext.Update(user);//Entry(user).State = EntityState.Modified;
        }

        public void UpdateRange(IEnumerable<User> entities)
        {
            dbContext.UpdateRange(entities);
        }
    }
}
