
using SchoolDemoApi.Data.Entities;
using SchoolDemoApi.Models;
using System;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDemoApi.DTOs
{
    public class CreateEntities
    {
        public static StudentEnrollment CreateStudentEnrollmentEntity(StudentEnrollmentModel model)
        {
            var studentEnrollment = new StudentEnrollment()
            {
                Date = model.Date,
                ProjectYear = model.ProjectYear,
                ReCollectData = model.ReCollectData,
                Verified = model.Verified,
                VisitorName = model.VisitorName
            };

            return studentEnrollment;
        }
        
    }
}
