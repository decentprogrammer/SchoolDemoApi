using System;
using System.Collections.Generic;

namespace SchoolDemoApi.Data.Entities
{
    public class StudentEnrollmentDetail
    {
        public StudentEnrollmentDetail()
        {

        }
        public int StudentEnrollmentDetailId { get; set; }       
        
        public short ClassId { get; set; }
        public short NewEnrolltGirls { get; set; }
        public short NewEnrollBoys { get; set; }
        public short AttendRegGirls { get; set; }
        public short AttendRegBoys { get; set; }
        public short HeadCountGirls { get; set; }
        public short HeadCountBoys { get; set; }
        public int StudentEnrollmentId { get; set; }
        public virtual StudentEnrollment? StudentEnrollment { get; set; }
    }
}
