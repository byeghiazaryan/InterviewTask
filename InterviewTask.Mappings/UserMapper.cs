using AutoMapper;
using InterviewTask.Data.Entities;
using InterviewTask.Models;
using System;

namespace InterviewTask.Mappings
{
    public class UserMapper:Profile
    {
        public UserMapper()
        {
            CreateMap<User, UserModel>();
            CreateMap<UserModel, User>()
                .ForMember(m => m.UpdatedDate, x => x.ResolveUsing(d => DateTime.Now));
        }
    }
}
