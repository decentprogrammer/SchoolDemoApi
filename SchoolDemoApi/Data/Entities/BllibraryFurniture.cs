using System;
using System.Collections.Generic;

namespace SchoolDemoApi.Data.Entities
{
    public partial class BllibraryFurniture
    {
        public short Blid { get; set; }
        public bool IsLibrary { get; set; }
        public bool? IsLibraryFunctional { get; set; }
        public bool LibReaNoBooks { get; set; }
        public bool LibReaNoFurniture { get; set; }
        public bool LibReaNoIncharge { get; set; }
        public bool LibSugElectrification { get; set; }
        public bool LibSugFurniture { get; set; }
        public bool LibSugRepair { get; set; }
        public bool IsLab { get; set; }
        public bool? IsLabFunctional { get; set; }
        public bool LabReaNoItem { get; set; }
        public bool LabReaNoRoom { get; set; }
        public bool LabReaNoFurniture { get; set; }
        public bool LabReaNoTeacher { get; set; }
        public bool LabSugNewItem { get; set; }
        public bool LabSugElectrification { get; set; }
        public bool LabSugFurniture { get; set; }
        public bool LabSugRepair { get; set; }
        public short Desks { get; set; }
        public short MultipurposeTables { get; set; }
        public short ArmChairs { get; set; }
        public short GilamEce { get; set; }
        public short DesksNeeded { get; set; }
        public short MultipurposeTablesNeeded { get; set; }
        public short ArmChairsNeeded { get; set; }
        public short GilamEceneeded { get; set; }
        public short TeacherChair { get; set; }
        public short TeacherChairNeeded { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual Baseline Bl { get; set; } = null!;
    }
}
