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
        private IStudentEnrollmentDetailService _studentEnrollmentDetailService;

        public StudentEnrollmentController(IStudentEnrollmentService studentEnrollmentService, IStudentEnrollmentDetailService studentEnrollmentDetailService)
        {
            _studentEnrollmentService = studentEnrollmentService;
            _studentEnrollmentDetailService = studentEnrollmentDetailService;
        }

        [HttpPost, Authorize]        
        public async Task<ActionResult> AddStudentEnrollment([FromBody] StudentEnrollmentModel model)
        {
            var schoolEnrollment = CreateEntities.CreateStudentEnrollmentEntity(model);
            var status = await _studentEnrollmentService.Insert(schoolEnrollment);
            if (model.StudentEnrollmentDetails.Count > 0)
            {
                foreach (var studentEnrollmentDetail in model.StudentEnrollmentDetails)
                {
                    var item = CreateEntities.CreateStudentEnrollmentDetailEntity(studentEnrollmentDetail);
                    item.StudentEnrollmentId = 1; // TODO: add the id of parent student enrollment
                    await _studentEnrollmentDetailService.Insert(item);
                }
            }
            
            return Ok(status);
        }


       
    }
}