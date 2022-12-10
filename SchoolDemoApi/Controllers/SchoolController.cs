using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolDemoApi.Data.Models;
using SchoolDemoApi.Services;

namespace SchoolDemoApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    public class SchoolController : ControllerBase
    {
        private ISchoolService _schoolService;

        public SchoolController(ISchoolService schoolService)
        {
            _schoolService = schoolService;
        }

        [HttpGet, Authorize]        
        public async Task<JsonResult> GetSchools()
        {
            var schools = (await _schoolService.GetSchools(false)).Select(x => new
            {
                Id = x.Sid,
                Name = x.SchoolName,
                Level = x.Level,
                District = x.District,
                UnionCouncil = x.Uc,
                VisitDate = DateTime.Now,
                UserId = 1
            }).ToList();
            return new JsonResult(schools);
        }


       
        [HttpGet("{id}"), Authorize]
        public async Task<JsonResult> GetSchoolById(int id)
        {
            var school = (await _schoolService.GetSchoolById(id, false));            
            var item = new
            {
                Id = school.Sid,
                Name = school.SchoolName,
                Level = school.Level,
                District = school.District,
                UnionCouncil = school.Uc,
                VisitDate = DateTime.Now,
                UserId = 1
            };
            return new JsonResult(item);
        }


    }
}