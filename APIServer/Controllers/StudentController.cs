using Microsoft.AspNetCore.Mvc;

namespace APIServer.Controllers
{
    [ApiController]
    [Route("student")]

    public class StudentController : ControllerBase
    {
        [HttpGet]
        public ActionResult GiveMeStudent()
        {
            Student student = new Student();
            student.Name = "Moise";
            student.Height = 180;
            return Ok(student);

        }
    }
}