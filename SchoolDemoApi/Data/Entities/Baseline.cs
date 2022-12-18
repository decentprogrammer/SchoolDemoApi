using System;
using System.Collections.Generic;

namespace SchoolDemoApi.Data.Entities
{
    public partial class Baseline
    {
        public Baseline()
        {
            BLteachers = new HashSet<BLteacher>();
            Blenrollments = new HashSet<Blenrollment>();
        }

        public short Blid { get; set; }
        public short? Sid { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public string TeacherName { get; set; } = null!;
        public string TeacherContact { get; set; } = null!;
        public string PtsmcName { get; set; } = null!;
        public string PtsmcContact { get; set; } = null!;
        public string VisitorName { get; set; } = null!;
        public string VisitorContact { get; set; } = null!;
        public string? Ptsmcmembers { get; set; }
        public short Within3kmPrimary { get; set; }
        public short NextLevelDistance { get; set; }
        public string? NextLevelSchool { get; set; }
        public DateTime VisitDate { get; set; }
        public bool? IsCommunityWilling { get; set; }
        public bool? IsLandAvailable { get; set; }
        public bool? IsOwnBuilding { get; set; }
        public bool? IsSpace { get; set; }
        public bool? IsSpacePlayArea { get; set; }
        public short Within3kmHigh { get; set; }
        public short Within3kmMiddle { get; set; }
        public bool? IsPtsmc { get; set; }
        public bool? IsPtsmcFunctional { get; set; }
        public bool? IsPtsmcTrained { get; set; }
        public string? NonFuntionalReasion { get; set; }
        public DateTime CreateDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool? IsLecFormed { get; set; }
        public bool? IsLecFunctional { get; set; }
        public bool? IsLecTrained { get; set; }
        public bool? IsSpaceVertical { get; set; }
        public string? OtherReason { get; set; }
        public bool? Verified { get; set; }
        public string? VerifiedBy { get; set; }
        public DateTime VerifiedDate { get; set; }
        public string? FunctionalReason { get; set; }
        public string? FunctionalStatus { get; set; }

        public virtual BlbuildingFacility? BlbuildingFacility { get; set; }
        public virtual BleceComputerLab? BleceComputerLab { get; set; }
        public virtual BllibraryFurniture? BllibraryFurniture { get; set; }
        public virtual ICollection<BLteacher> BLteachers { get; set; }
        public virtual ICollection<Blenrollment> Blenrollments { get; set; }
    }
}
