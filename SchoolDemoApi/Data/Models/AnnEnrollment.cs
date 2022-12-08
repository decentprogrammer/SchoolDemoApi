using System;
using System.Collections.Generic;

namespace SchoolDemoApi.Data.Models
{
    public partial class AnnEnrollment
    {
        public int AnnualEnrolId { get; set; }
        public int SchoolId { get; set; }
        public short UserId { get; set; }
        public int Year { get; set; }
        public short? ProjectYear { get; set; }
        public DateTime Date { get; set; }
        public string? VisitorName { get; set; }
        public string? PhotoRegAdmissionWtd { get; set; }
        public bool? RecollectData { get; set; }
        public bool? Verified { get; set; }
        public string? VerifiedBy { get; set; }
    }
}
