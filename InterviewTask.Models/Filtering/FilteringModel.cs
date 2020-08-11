using InterviewTask.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTask.Models.Filtering
{
    public class Filter
    {
        public bool? IsActive { get; set; }
        public UserType? Classification { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte? Age { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? Id { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
    }
}

