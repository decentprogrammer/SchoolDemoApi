using System;
using System.Collections.Generic;

namespace SchoolDemoApi.Data.Entities
{
    public partial class School
    {
        public School()
        {
            StudentEnrollments = new HashSet<StudentEnrollment>();
        }

        public short? SchoolId { get; set; }
        public string? Bemis { get; set; }
        public string? SchoolName { get; set; }
        public string? District { get; set; }
        public string? Uc { get; set; }
        public string? Tehsil { get; set; }
        public string? Gender { get; set; }
        public string? Level { get; set; }
        public string? Category { get; set; }
        public string? Zone { get; set; }
        public string? ClusterBemis { get; set; }
        public string? ClusterSchool { get; set; }
        public string? Latitude { get; set; }
        public string? Longitude { get; set; }
        public short Blstep { get; set; }
        public bool? IsIctlab { get; set; }
        public bool? IsProjectFocused { get; set; }
        public bool? IsScienceLab { get; set; }
        public bool? IsSolar { get; set; }

        public virtual ICollection<StudentEnrollment> StudentEnrollments { get; set; }
    }
}
