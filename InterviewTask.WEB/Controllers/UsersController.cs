using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using InterviewTask.Common;
using InterviewTask.Data;
using InterviewTask.Data.Entities;
using InterviewTask.Data.Paging;
using InterviewTask.Models;
using InterviewTask.Models.Filtering;
using InterviewTask.Models.Paging;
using InterviewTask.Services;
using Microsoft.AspNetCore.Mvc;

namespace InterviewTask.WEB.Controllers
{
    //[ApiVersion("1.0")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsersController : BaseController
    {
        private readonly IUserService usersService;
        private readonly IMapper mapper;
        public UsersController(
            IUnitOfWork unitOfWork,
            IUserService usersService,
            IMapper mapper) : base(unitOfWork)
        {
            this.usersService = usersService;
            this.mapper = mapper;

        }

        [HttpPost]
        public async Task SeedUsers()
        {
            List<User> fakeUsersArray = new List<User>();
            for (int index = 0; index < 100; index++)
            {
                var firstName = Faker.Name.First();
                var lastName = Faker.Name.Last();
                fakeUsersArray.Add(new User()
                {
                    Age = (byte)Faker.RandomNumber.Next(16, 85),
                    Classification = (UserType)Faker.RandomNumber.Next(1, 3),
                    IsActive = true,
                    FirstName = firstName,
                    LastName = lastName,
                    Mobile = Faker.Phone.Number(),
                    UpdatedDate = DateTime.Now.AddDays(Faker.RandomNumber.Next(1, 200)),
                    Email = Faker.Internet.Email($"{firstName}{lastName}"),
                    CreatedDate = DateTime.Now.AddDays(Faker.RandomNumber.Next(1, 200)),
                });
            }
            await usersService.BulkCreateUser(fakeUsersArray);
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<UserModel>>> GetUsers(UserRequestModel requestModel)
        {
            var mappedPaging=mapper.Map<PagingModel, Pagination>(requestModel.paging);

            var allUsers = await usersService.GetAllUsers(mappedPaging, requestModel.filter);
            var mappedUsers = mapper.Map<IEnumerable<User>, IEnumerable<UserModel>>(allUsers);
            requestModel.paging.Count = mappedPaging.Count;
            UserPagingResponseModel responseModel = new UserPagingResponseModel()
            {
                users=mappedUsers,
                paging= requestModel.paging,
                filtering = requestModel.filter
            };
            return Ok(responseModel);
        }


        [HttpGet]
        public async Task<ActionResult<UserModel>> GetUser(int UserId)
        {
            var user = await usersService.GetUser(UserId);
            var mappedUser = mapper.Map<User, UserModel>(user);
            return Ok(mappedUser);
        }


        [HttpPost]
        public async Task<IActionResult> CreateUser(UserModel user)
        {
            var mapped = mapper.Map<UserModel, User>(user);
            var newUser = await usersService.CreateUser(mapped);

            var mappedCreatedUser= mapper.Map<User, UserModel>(newUser);

            var allUsers = await usersService.GetAllUsers(new Pagination(), new Filter());
            var mappedUsers = mapper.Map<IEnumerable<User>, IEnumerable<UserModel>>(allUsers);

            var paging = new PagingModel()
            {
                Count = allUsers.Count(),
                Page = new Models.Paging.PageData(),
                Sort = new Models.Paging.SortData()
            };

            UserPagingResponseModel responseModel = new UserPagingResponseModel()
            {
                users = mappedUsers,
                paging = paging,
                filtering = new Filter()
            };
            return Ok(responseModel);
        }


        [HttpPut]
        public async Task<IActionResult> UpdateUser(UserRequestModel requestModel)
        {
            var mapped = mapper.Map<UserModel, User>(requestModel.user);
            var mappedPaging = mapper.Map<PagingModel, Pagination>(requestModel.paging);

            await usersService.UpdateUser(mapped);

            var allUsers = await usersService.GetAllUsers(mappedPaging, requestModel.filter);
            var mappedUsers = mapper.Map<IEnumerable<User>, IEnumerable<UserModel>>(allUsers);

            requestModel.paging.Count = mappedPaging.Count;

            UserPagingResponseModel responseModel = new UserPagingResponseModel()
            {
                users = mappedUsers,
                paging = requestModel.paging,
                filtering = requestModel.filter
            };
            return Ok(responseModel);
        }


        [HttpPost]
        public async Task<IActionResult> DeleteUser(UserRequestModel requestModel)
        {
            await usersService.DeleteUser(requestModel.user.Id.Value);

            var mappedPaging = mapper.Map<PagingModel, Pagination>(requestModel.paging);

            var allUsers = await usersService.GetAllUsers(mappedPaging, requestModel.filter);
            var mappedUsers = mapper.Map<IEnumerable<User>, IEnumerable<UserModel>>(allUsers);

            requestModel.paging.Count = mappedPaging.Count;

            UserPagingResponseModel responseModel = new UserPagingResponseModel()
            {
                users = mappedUsers,
                paging = requestModel.paging,
                filtering = requestModel.filter
            };
            return Ok(responseModel);
        }

        //INFO: In my point of view, this action is not necessary. This can be useful in admin environments. 
        [HttpPost]
        public async Task DeleteUsers([FromBody]int[] Ids)
        {
            await usersService.DeleteUsers(Ids);
        }
    }
}
