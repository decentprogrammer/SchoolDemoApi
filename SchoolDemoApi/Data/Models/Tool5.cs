using System;
using System.Collections.Generic;

namespace SchoolDemoApi.Data.Models
{
    public partial class Tool5
    {
        public Tool5()
        {
            Tool5Details = new HashSet<Tool5Detail>();
        }

        public int SchoolId { get; set; }
        public short Quarter { get; set; }
        public short Year { get; set; }
        public short ProjectYear { get; set; }
        public DateTime Date { get; set; }
        public string? VisitorName { get; set; }
        public bool ReCollectData { get; set; }
        public bool Verified { get; set; }
        public string? VerifiedBy { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public short? SchoolSid { get; set; }

        public virtual School? SchoolS { get; set; }
        public virtual ICollection<Tool5Detail> Tool5Details { get; set; }
    }
}
