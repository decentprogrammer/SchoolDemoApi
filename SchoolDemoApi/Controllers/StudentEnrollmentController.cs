using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolDemoApi.Data.Entities;
using SchoolDemoApi.Services;
using SchoolDemoApi.Models;
using SchoolDemoApi.DTOs;

namespace SchoolDemoApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    public class StudentEnrollmentController : ControllerBase
    {
        private IStudentEnrollmentService _studentEnrollmentService;

        public StudentEnrollmentController(IStudentEnrollmentService studentEnrollmentService)
        {
            _studentEnrollmentService = studentEnrollmentService;
        }

        [HttpPost, Authorize]        
        public async Task<ActionResult> AddStudentEnrollment([FromBody] StudentEnrollmentModel model)
        {
            var schoolEnrollment = CreateEntities.CreateStudentEnrollmentEntity(model);
            var status = await _studentEnrollmentService.Insert(schoolEnrollment);
            return Ok(status);
        }


       
    }
}