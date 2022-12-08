using System;
using System.Collections.Generic;

namespace SchoolDemoApi.Data.Models
{
    public partial class EssSiting
    {
        public short Sid { get; set; }
        public bool? AdditionalLand { get; set; }
        public bool? LandMutation { get; set; }
        public bool? FloodPath { get; set; }
        public string? FloodPathImage { get; set; }
        public bool? LandSlideArea { get; set; }
        public string? LandSlideAreaImage { get; set; }
        public bool? Hill { get; set; }
        public string? HillImage { get; set; }
        public bool? SalineLand { get; set; }
        public string? SalineLandImage { get; set; }
        public bool? WasetDumps { get; set; }
        public string? WasetDumpsImage { get; set; }
        public bool? ClusterTrees { get; set; }
        public string? ClusterTreesImage { get; set; }
        public short TreesNum { get; set; }
        public bool? HighwayAway { get; set; }
        public bool? TransmissionLines { get; set; }
        public string? TransmissionLinesImage { get; set; }
        public string? TransmissionType { get; set; }
        public bool? ElectricPoleInside { get; set; }
        public string? ElectricPoleType { get; set; }
        public string? ElectricPoleImage { get; set; }
        public bool? HandWashArea { get; set; }
        public string? HandWashAreaRepair { get; set; }
        public bool? FireExtinguisher { get; set; }
        public bool? FireBlanket { get; set; }
        public bool? SandBuckets { get; set; }
        public bool? WasteBinClasses { get; set; }
        public bool? WasteBinPlayground { get; set; }
        public bool? TreesInSchool { get; set; }
        public short TreesInSchoolNum { get; set; }
        public bool? SpaceForPlantation { get; set; }
        public bool? WaterAvailable { get; set; }
        public bool? BuildingOnGround { get; set; }
        public bool? BuildingRamp { get; set; }
        public bool? BuildingHandrail { get; set; }
        public bool? ToiletOnGround { get; set; }
        public bool? ToiletRamp { get; set; }
        public bool? ToiletHandrail { get; set; }
        public short DifferentChild { get; set; }
        public DateTime VisitDate { get; set; }
        public string? VisitedBy { get; set; }
        public string? Designation { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool Verified { get; set; }
        public string? VerifiedBy { get; set; }
        public DateTime VerifiedDate { get; set; }
        public bool? BuildingDepression { get; set; }
        public bool? ProperFlowOut { get; set; }

        public virtual School SidNavigation { get; set; } = null!;
    }
}
