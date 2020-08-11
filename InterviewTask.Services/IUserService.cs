using InterviewTask.Data.Entities;
using InterviewTask.Data.Paging;
using InterviewTask.Models.Filtering;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InterviewTask.Services
{
    public interface IUserService
    {
        Task<User> GetUser(int Id);
        Task<IEnumerable<User>> GetUsers(int[] Ids);
        Task<IEnumerable<User>> GetAllUsers(Pagination pagination, Filter filter);
        Task<User> CreateUser(User user);
        Task UpdateUser(User user);
        Task DeleteUser(int Id);
        Task DeleteUsers(int[] usersId);
        Task BulkCreateUser(IEnumerable<User> users);
    }
}