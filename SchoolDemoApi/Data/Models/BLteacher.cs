using System;
using System.Collections.Generic;

namespace SchoolDemoApi.Data.Models
{
    public partial class BLteacher
    {
        public short Id { get; set; }
        public short Blid { get; set; }
        public short PostId { get; set; }
        public short TeachersPost { get; set; }
        public short TrainedEce { get; set; }
        public short TrainedInduction { get; set; }
        public DateTime CreateDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual Baseline Bl { get; set; } = null!;
        public virtual TeacherPost Post { get; set; } = null!;
    }
}
