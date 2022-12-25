
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
                Date = model.VisitDate,
                ProjectYear = model.ProjectYear,
                VisitorName = model.VisitorName,
                SchoolId = model.SchoolId,
                Quarter = model.Quarter
            };

            return studentEnrollment;
        }
        
        public static StudentEnrollmentDetail CreateStudentEnrollmentDetailEntity(StudentEnrollmentDetailModel model)
        {
            var studentEnrollmentDetail = new StudentEnrollmentDetail()
            {
                AttendRegBoys = model.AttendRegBoys,
                AttendRegGirls = model.AttendRegGirls,
                ClassId = model.ClassId,
                HeadCountBoys = model.HeadCountBoys,
                HeadCountGirls = model.HeadCountGirls,
                NewEnrollBoys = model.NewEnrollBoys,
                NewEnrolltGirls = model.NewEnrollGirls,
                
            };

            return studentEnrollmentDetail;
        }
        
    }
}
