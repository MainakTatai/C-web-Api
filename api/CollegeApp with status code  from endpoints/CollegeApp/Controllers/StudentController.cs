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
        public ActionResult<IEnumerable<Student>> GetStudents()
        {
            //ok=200
            return Ok(CollegeRepository.Students);
        }

        //[HttpGet("{id:int}")]
        [HttpGet]
        [Route("{id:int}",Name ="GetStudentById")]
        public ActionResult<Student> GetStudentById(int id)
        {
            //400-bad request-client error
            if (id <= 0)
                return BadRequest();

            var student = CollegeRepository.Students.Where(n => n.Id == id).FirstOrDefault();
            //404-Not found
            if (student == null)
                 return NotFound($"The student with  id {id} is not found");
            //ok
            return Ok(student);
        }

        //[HttpGet]
        //[Route("{id}", Name = "GetStudentById")]

        [HttpGet("{name:alpha}", Name = "GetStudentByName")]

        public ActionResult<Student> GetStudentsByName(string name)
        {

            if (string.IsNullOrEmpty(name))
                return BadRequest();

            var student = CollegeRepository.Students.Where(n => n.StudentName == name).FirstOrDefault();
            //404-Not found
            if (student == null)
                return NotFound($"The student with  id {id} is not found");
            return Ok(student);
        }
    

       // [HttpDelete]
        [HttpDelete("{id:min(1):max(100)}", Name = "DeleteStudentById")]
        public ActionResult<bool> DeleteStudents(int id)
        {
            if (id <= 0)
                return BadRequest();

            var student = CollegeRepository.Students.Where(n => n.Id == id).FirstOrDefault();
            //404-Not found
            if (student == null)
                return NotFound($"The student with  id {id} is not found");

            
            CollegeRepository.Students.Remove(student);

            return true;
        }
    }
}
