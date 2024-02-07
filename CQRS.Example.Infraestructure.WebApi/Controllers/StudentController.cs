using CQRS.Example.Application.Contracts;
using CQRS.Example.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CQRS.Example.Infraestructure.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentLogic studentLogic;

        public StudentController(IStudentLogic studentLogic)
        {
            this.studentLogic = studentLogic;
        }

        [HttpGet]
        [Route("GetStudents")]
        public async Task<IActionResult> GetStudents()
        {
            try
            {
                return this.Ok(await this.studentLogic.GetStudents());
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("GetStudentById")]
        public async Task<IActionResult> GetStudentById(string id)
        {
            try
            {
                return this.Ok(await this.studentLogic.GetStudentById(id));
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddStudent(Student student)
        {
            try
            {
                return this.Ok(await this.studentLogic.AddStudent(student));
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }
    }
}