
using SchoolDemoApi.Data.Entities;
using SchoolDemoApi.Models;
using System;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDemoApi.DTOs
{
    public class CreateModels
    {
        public static StudentEnrollmentModel CreateStudentEnrollmentModel(StudentEnrollment studentEnrollment)
        {
            var model = new StudentEnrollmentModel()
            {
                VisitDate = studentEnrollment.Date,
                ProjectYear = studentEnrollment.ProjectYear,
                VisitorName = studentEnrollment.VisitorName
            };

            return model;
        }
        
    }
}
