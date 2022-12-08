using System;
using System.Collections.Generic;

namespace SchoolDemoApi.Data.Models
{
    public partial class Essconstruction
    {
        public short Sid { get; set; }
        public bool? IsPond { get; set; }
        public bool? IsArtifact { get; set; }
        public bool? IsSewerage { get; set; }
        public bool? IsConstructionWaste { get; set; }
        public bool? IsCuttingTree { get; set; }
        public short TreeRemoved { get; set; }
        public bool? IsCompensatoryPlantation { get; set; }
        public bool? ReaNoBudget { get; set; }
        public bool? ReaTimeOver { get; set; }
        public bool? ReaNoLand { get; set; }
        public bool? ReaNoWater { get; set; }
        public bool? IsWasteWaterTowardsPlantation { get; set; }
        public bool? IsNoPlantationArea { get; set; }
        public bool? IsSeparateToiletsConstructed { get; set; }
        public string? ReasonNoSeparateToilets { get; set; }
        public bool? IsConstructionObstruction { get; set; }
        public bool? IsConstructionDisruptedSchool { get; set; }
        public bool? IsRiskGbv { get; set; }
        public bool? IsCodeOfConductSigned { get; set; }
        public bool? IsFenced { get; set; }
        public bool? IsPardaArrangement { get; set; }
        public bool? IsEmergencyExist { get; set; }
        public short EmergencyExistRooms { get; set; }
        public bool? IsSafetyTraining { get; set; }
        public bool? IsBoots { get; set; }
        public bool? IsGloves { get; set; }
        public bool? IsHelmet { get; set; }
        public bool? IsHandWashArea { get; set; }
        public bool? IsRaisedSchoolRamp { get; set; }
        public bool? IsRaisedSchoolHandrail { get; set; }
        public bool? IsNewToiletRamp { get; set; }
        public bool? IsnewToiletHandrail { get; set; }
        public bool? IsExistingToiletRamp { get; set; }
        public bool? IsExistingToilethandrail { get; set; }
        public bool? IsEsmpguidelines { get; set; }
        public DateTime VisitDate { get; set; }
        public string VisitedBy { get; set; } = null!;
        public string Designation { get; set; } = null!;
        public string? CreatedBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool Verified { get; set; }
        public string? VerifiedBy { get; set; }
        public DateTime VerifiedDate { get; set; }
        public short? SchoolSid { get; set; }

        public virtual School? SchoolS { get; set; }
    }
}
