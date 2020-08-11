using InterviewTask.Common;
using InterviewTask.Models.Filtering;
using InterviewTask.Models.Paging;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewTask.Models
{
    public class UserModel
    {
        public int? Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public byte? Age { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool IsActive { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public UserType Classification { get; set; }
    }
    public class UserPagingResponseModel
    {
        public IEnumerable<UserModel> users { get; set; }
        public PagingModel paging { get; set; }
        public Filter filtering { get; set; }
    }
    public class UserRequestModel
    {
        public PagingModel paging { get; set; }
        public Filter filter { get; set; }
        public UserModel user { get; set; }
    }

}
