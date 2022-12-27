using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolDemoApi.Data.Entities;
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
                SID = x.SchoolId,
                SchoolName = x.SchoolName,
                SchoolLevel = x.Level,
                District = x.District,
                UnionCouncil = x.Uc,
                Tehsil = x.Tehsil,                
                Quater = 1
            }).ToList();
            return new JsonResult(schools);
        }


       
        [HttpGet("{id}"), Authorize]
        public async Task<JsonResult> GetSchoolById(int id)
        {
            var school = (await _schoolService.GetSchoolById(id, false));            
            var item = new
            {
                SID = school.SchoolId,
                SchoolName = school.SchoolName,
                SchoolLevel = school.Level,
                District = school.District,
                Tehsil = school.Tehsil,
                UnionCouncil = school.Uc,                
                Quater = 1
            };
            return new JsonResult(item);
        }


    }
}