using System;
using System.Collections.Generic;

namespace SchoolDemoApi.Data.Entities
{
    public partial class AnnEnrollmentDetail
    {
        public int AnnualEnrollmentDetails { get; set; }
        public int AnnualEnrolId { get; set; }
        public short ClassId { get; set; }
        public short NewEnrollGirls { get; set; }
        public short NewEnrollBoys { get; set; }
        public short NewEnrollTotal { get; set; }
        public short? AttendRegGirls { get; set; }
        public short? AttendRegBoys { get; set; }
        public short? AttendRegTotal { get; set; }
        public string? AttendRegPhoto { get; set; }
    }
}
