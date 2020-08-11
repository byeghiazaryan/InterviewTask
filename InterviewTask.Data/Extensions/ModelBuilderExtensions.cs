using InterviewTask.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace InterviewTask.Data.Extensions
{
    /// <summary>
    /// Extension method for "ModelBuilder" which can be used in "OnModelCreating" method in ApplicationDBContext
    /// </summary>
    public static class ModelBuilderExtensions
    {
        private static string[] CascadeDeletePermittedFK = new string[]{
            typeof(User).FullName
        };
        
        public static void DataSeed(this ModelBuilder builder)
        {
           
        }

        //Gathers the types, for which cascadeDelete is permitted.
        public static string[] CascadeDeletePermitted_FK_Types(this ModelBuilder builder)
        {
            return CascadeDeletePermittedFK;
        }


    }
}
