using System;
using System.Collections.Generic;

namespace SchoolDemoApi.Data.Entities
{
    public partial class Blenrollment
    {
        public short Id { get; set; }
        public short Blid { get; set; }
        public short ClassId { get; set; }
        public short EnrollBoys { get; set; }
        public short EnrollGirls { get; set; }
        public DateTime CreateDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual Baseline Bl { get; set; } = null!;
    }
}
