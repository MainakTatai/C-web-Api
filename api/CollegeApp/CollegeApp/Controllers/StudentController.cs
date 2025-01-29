using CollegeApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CollegeApp.Controllers
{
    [Route("Api/[Controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Student> GetStudents()
        {
            return new List<Student>{ 
            new Student
            {
                Id=1,
                StudentName="Mainak",
                Email="xyz@gmail.com",
                Address="abc"

            },
             new Student
             {
                 Id = 1,
                 StudentName = "Mainak",
                 Email = "xyz@gmail.com",
                 Address = "abc"

             }

            };
        }
    }
}
