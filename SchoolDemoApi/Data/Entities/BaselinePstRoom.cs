using System;
using System.Collections.Generic;

namespace SchoolDemoApi.Data.Entities
{
    public partial class BaselinePstRoom
    {
        public short Srid { get; set; }
        public short? Sid { get; set; }
        public decimal RoomLength { get; set; }
        public decimal RoomWidth { get; set; }
        public decimal RoomHeight { get; set; }
        public bool IsPaintRequired { get; set; }
        public int TotalRoomDoor { get; set; }
        public int TotalRoomDoorReplace { get; set; }
        public int TotalRoomDoorRepair { get; set; }
        public int TotalRoomWindow { get; set; }
        public int TotalRoomWindowReplace { get; set; }
        public int TotalRoomWindowRepair { get; set; }
        public int TotalRoomVentilator { get; set; }
        public int TotalRoomVentilatorReplace { get; set; }
        public int TotalRoomVentilatorRepair { get; set; }
        public int TotalRoomLightRequired { get; set; }
        public int TotalRoomFanRequired { get; set; }
        public bool IsFlooringRequired { get; set; }
        public bool IsPlasterRequired { get; set; }
        public bool IsRoofScreedingRequired { get; set; }
        public short? SchoolSID { get; set; }

        public virtual School? SchoolS { get; set; }
    }
}
