using System;
using System.Collections.Generic;

namespace SchoolDemoApi.Data.Entities
{
    public partial class BleceComputerLab
    {
        public short Blid { get; set; }
        public bool IsEce { get; set; }
        public bool IsEceTeacher { get; set; }
        public bool? IsEceTeacherTrained { get; set; }
        public bool IsEceMaterial { get; set; }
        public bool? IsEceMaterialUsing { get; set; }
        public bool IsAssessment { get; set; }
        public string? AssessmentFrequency { get; set; }
        public bool IsVisitBaec { get; set; }
        public string? VisitPurpose { get; set; }
        public bool IsComputerLab { get; set; }
        public bool? IsComputerLabFunctional { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool? ReaNoComputer { get; set; }
        public bool? ReaNoTeacher { get; set; }
        public bool? ReaNoUsingCondition { get; set; }
        public bool? ReqElectrification { get; set; }
        public bool? ReqFurniture { get; set; }
        public bool? ReqNewComputer { get; set; }
        public bool? ReaLoadShedding { get; set; }
        public bool? ReqRepairLab { get; set; }
        public bool? ReqSolarSystem { get; set; }
        public short? WorkingComputers { get; set; }
        public bool? ReaNoElectric { get; set; }

        public virtual Baseline Bl { get; set; } = null!;
    }
}
