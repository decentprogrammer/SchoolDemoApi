using System;
using System.Collections.Generic;

namespace SchoolDemoApi.Data.Entities
{
    public partial class AnnBemiscode
    {
        public int Bemisid { get; set; }
        public short Year { get; set; }
        public short? ProjectYear { get; set; }
        public DateTime Date { get; set; }
        public short UserId { get; set; }
        public string? VisitorName { get; set; }
        public bool? ReCollectData { get; set; }
        public bool? Verified { get; set; }
        public string? VerifiedBy { get; set; }
    }
}
