using System;
using System.Collections.Generic;

namespace SchoolDemoApi.Data.Models
{
    public partial class Tool5Detail
    {
        public int SchoolId { get; set; }
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
        public short? SchoolSid { get; set; }

        public virtual School? SchoolS { get; set; }
        public virtual Tool5 Tool5 { get; set; } = null!;
    }
}
