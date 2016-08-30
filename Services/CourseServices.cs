using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Services
{
    public class AuthCoursesSender : ClassServices
    {
        public Task GetCourseBySemester(string semester)
        {
            return Task.FromResult(0);
        }
    }
}