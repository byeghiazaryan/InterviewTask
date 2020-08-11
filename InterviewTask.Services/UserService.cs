using InterviewTask.Data;
using InterviewTask.Data.Entities;
using InterviewTask.Data.Paging;
using InterviewTask.Models.Filtering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTask.Services
{
    public class UserService : ServiceBase, IUserService
    {
        public UserService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
           
        }

        public async Task<User> GetUser(int Id)
        {
            var _user = await unitOfWork.UserRepository.Get(Id);
            return _user;
        }

        public async Task<IEnumerable<User>> GetUsers(int[] Ids)
        {
            var _user = await unitOfWork.UserRepository.Get(Ids).ToListAsync();
            return _user;
        }

        public async Task<IEnumerable<User>> GetAllUsers(Pagination pagination, Filter filter)
        {
            var _users = await unitOfWork.UserRepository.GetAll(pagination, filter).ToListAsync();
            
            return _users;
        }

        public async Task<User> CreateUser(User user)
        {
            var _user = await unitOfWork.UserRepository.Add(user);
            _user.CreatedDate = DateTime.Now;
            await unitOfWork.SaveAsync();
            return _user;
        }

        public async Task BulkCreateUser(IEnumerable<User> users)
        {
            await unitOfWork.UserRepository.AddRangeAsync(users);
            await unitOfWork.SaveAsync();
        }

        public async Task UpdateUser(User user)
        {
            var _user = await GetUser(user.Id);
            if (_user != null)
            {
                unitOfWork.UserRepository.Update(user);
                await unitOfWork.SaveAsync();
            }
        }



        public async Task DeleteUser(int Id)
        {
            var user = await unitOfWork.UserRepository.Get(Id);
            if (user != null)
            {
                unitOfWork.UserRepository.Remove(user);
                await unitOfWork.SaveAsync();
            }
        }

        public async Task DeleteUsers(int[] usersIds)
        {
            var users = await GetUsers(usersIds);
            if (users.Any())
            {
                unitOfWork.UserRepository.RemoveRange(users);
                await unitOfWork.SaveAsync();
            }
        }
    }
}
