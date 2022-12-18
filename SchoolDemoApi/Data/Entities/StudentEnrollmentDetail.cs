using System;
using System.Collections.Generic;

namespace SchoolDemoApi.Data.Entities
{
    public partial class StudentEnrollmentDetail
    {
        public short Quarter { get; set; }
        public short ClassId { get; set; }
        public short NewEnrolltGirls { get; set; }
        public short NewEnrollBoys { get; set; }
        public short AttendRegGirls { get; set; }
        public short AttendRegBoys { get; set; }
        public short HeadCountGirls { get; set; }
        public short HeadCountBoys { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public short? SchoolSID { get; set; }

        public virtual School? SchoolS { get; set; }
        public virtual StudentEnrollment StudentEnrollment { get; set; } = null!;
    }
}
