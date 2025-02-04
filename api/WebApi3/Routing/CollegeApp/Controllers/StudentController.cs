using CollegeApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CollegeApp.Controllers
{
    [Route("Api/[Controller]")] //if we want controller name modified in api we should route like this
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        [Route("All", Name = "GetAllStudent")]
        public IEnumerable<Student> GetStudents()
        {
            return CollegeRepository.Students;
        }

        //[HttpGet("{id:int}")]
        [HttpGet]
        [Route("{id:int}",Name ="GetStudentById")]
        public Student GetStudentById(int id)
        {
            return CollegeRepository.Students.Where(n => n.Id == id).FirstOrDefault();
        }

        //[HttpGet]
        //[Route("{id}", Name = "GetStudentById")]

        [HttpGet("{name:alpha}", Name = "GetStudentByName")]

        public Student GetStudentsByName(string name)
        {
            return CollegeRepository.Students.Where(n => n.StudentName == name).FirstOrDefault();
        }
    

       // [HttpDelete]
        [HttpDelete("{id:min(1):max(100)}", Name = "DeleteStudentById")]
        public bool DeleteStudents(int id)
        {
            var student= CollegeRepository.Students.Where(n => n.Id == id).FirstOrDefault();
            CollegeRepository.Students.Remove(student);

            return true;
        }
    }
}
