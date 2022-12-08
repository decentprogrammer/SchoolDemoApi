using System;
using System.Collections.Generic;

namespace SchoolDemoApi.Data.Models
{
    public partial class BlbuildingFacility
    {
        public short Blid { get; set; }
        public short RoomsTotal { get; set; }
        public short RoomsFunction { get; set; }
        public short RoomsNonFunction { get; set; }
        public short RoomsNeedConstruct { get; set; }
        public short RoomsNeedRepair { get; set; }
        public short ToiletsTotal { get; set; }
        public short ToiletsFunction { get; set; }
        public short ToiletsNonFunction { get; set; }
        public short ToiletsNeedConstruct { get; set; }
        public short ToiletsNeedRepair { get; set; }
        public bool PlayArea { get; set; }
        public bool? Boundrywall { get; set; }
        public bool? BoundrywallNew { get; set; }
        public bool? WindowRepair { get; set; }
        public bool? DoorsRepair { get; set; }
        public bool? GateRepair { get; set; }
        public bool IsWater { get; set; }
        public string? WaterFacility { get; set; }
        public bool IsElectricity { get; set; }
        public bool? IsElectricityInArea { get; set; }
        public bool IsGas { get; set; }
        public bool? IsGasInArea { get; set; }
        public bool IsWaterTank { get; set; }
        public string? WaterTankType { get; set; }
        public bool? IsWaterTankNeeded { get; set; }
        public bool? IsPump { get; set; }
        public bool? IsPumpFunctional { get; set; }
        public bool? IsPumpNeeded { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public short RoomsKachaFunction { get; set; }
        public short RoomsKachaNeedRepair { get; set; }
        public short RoomsKachaNonFunction { get; set; }
        public short RoomsKachaTotal { get; set; }
        public short ToiletsBoysFunction { get; set; }
        public short ToiletsBoysNeedConstruct { get; set; }
        public short ToiletsBoysNeedRepair { get; set; }
        public short ToiletsBoysTotal { get; set; }
        public string? WaterFacilityOther { get; set; }
        public short ToiletsBoysNonFunction { get; set; }

        public virtual Baseline Bl { get; set; } = null!;
    }
}
