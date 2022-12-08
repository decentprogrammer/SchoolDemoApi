using System;
using System.Collections.Generic;

namespace SchoolDemoApi.Data.Models
{
    public partial class BaselineEss
    {
        public short Sid { get; set; }
        public bool? SignificantLandDisturbance { get; set; }
        public bool? DestructionVegetation { get; set; }
        public bool? EncroachmentUrban { get; set; }
        public bool? RequiresRawMaterials { get; set; }
        public bool? GenerateConstructionMaterial { get; set; }
        public bool? ResidualWastes { get; set; }
        public bool? SoilErosion { get; set; }
        public bool? SoilWaterContamination { get; set; }
        public bool? ContaminatioGroundWater { get; set; }
        public bool? ContaminationSurfaceWater { get; set; }
        public bool? UseOfChemicals { get; set; }
        public bool? ContaminationSoil { get; set; }
        public bool? StagnantWaterBodies { get; set; }
        public bool? HarmfulAirEmissions { get; set; }
        public bool? AmbientNoiseLevels { get; set; }
        public bool? TransportHazardous { get; set; }
        public bool? DisturbanceDrainageChannels { get; set; }
        public bool? DestructionWildlife { get; set; }
        public bool? UnplannedInfrastructure { get; set; }
        public bool? ErosionLand { get; set; }
        public bool? CulturalSites { get; set; }
        public bool? Archaeological { get; set; }
        public bool? ReligiousMonuments { get; set; }
        public bool? DemolitionExistingStructures { get; set; }
        public bool? SocialDisruption { get; set; }
        public bool? EnvironmentalSocialDisturbance { get; set; }
        public bool? AffectIncomeLevels { get; set; }
        public bool? ReduceAccessSchool { get; set; }
        public bool? EnvironmentalSocialImpacts { get; set; }
        public bool? ImpactWomen { get; set; }
        public bool? IncreaseSocialInequalities { get; set; }
        public bool? ImpactsEthnicGroups { get; set; }
        public bool? ChallengesEngagingWomen { get; set; }
        public bool? AttractForcedLabor { get; set; }
        public bool? OverloadSocialInfrastructure { get; set; }
        public bool? ResettlementPopulation { get; set; }
        public bool? Laboratory { get; set; }
        public bool? LabFunctional { get; set; }
        public bool? LabVentilated { get; set; }
        public bool? LabWaste { get; set; }
        public bool? LabWasteDispose { get; set; }
        public bool? RequireLandAcquisition { get; set; }
        public bool? LandDonatedVoluntarily { get; set; }
        public bool? OwnerAwareDonation { get; set; }
        public string? NotMoreThan10 { get; set; }
        public bool? PossionOnePerson { get; set; }
        public bool? LandownerAgreedVld { get; set; }
        public bool? VldSignedAll { get; set; }
        public bool? ContestedOwnership { get; set; }
        public bool? SecurityProblems { get; set; }
        public bool? NaturalReserves { get; set; }
        public bool? GroundWaterSource { get; set; }
        public bool? SurfaceWaterBodies { get; set; }
        public bool? WaterCourses { get; set; }
        public bool? Wetlands { get; set; }
        public bool? RefugeesSettled { get; set; }
        public bool? WasteDump { get; set; }
        public bool? AccessPotableWater { get; set; }
        public bool? WastewaterNetwork { get; set; }
        public bool? One2KmAccessible { get; set; }
        public string? VisitedBy { get; set; }
        public string? Designation { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool Verified { get; set; }
        public string? VerifiedBy { get; set; }
        public DateTime VerifiedDate { get; set; }
        public short? SchoolSid { get; set; }
        public DateTime VisitDate { get; set; }
        public bool? ItLab { get; set; }
        public bool? ItLabFire { get; set; }
        public bool? ItLabVentilated { get; set; }

        public virtual School? SchoolS { get; set; }
    }
}
