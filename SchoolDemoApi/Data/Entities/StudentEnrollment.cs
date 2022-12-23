using System;
using System.Collections.Generic;

namespace SchoolDemoApi.Data.Entities
{
    public partial class StudentEnrollment
    {
        public StudentEnrollment()
        {

        }
        public int StudentEnrollmentId { get; set; }
        
        public short Quarter { get; set; }
        public short Year { get; set; }
        public short ClassId { get; set; }
        public short ProjectYear { get; set; }
        public DateTime Date { get; set; }
        public string? VisitorName { get; set; }
        public bool ReCollectData { get; set; }
        public bool Verified { get; set; }
        public string? VerifiedBy { get; set; }
        public short NewEnrolltGirls { get; set; }
        public short NewEnrollBoys { get; set; }
        public short AttendRegGirls { get; set; }
        public short AttendRegBoys { get; set; }
        public short HeadCountGirls { get; set; }
        public short HeadCountBoys { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public short SchoolId { get; set; }
        public virtual School? School { get; set; }
    }
}
