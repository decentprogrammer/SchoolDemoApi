using System;
using System.Collections.Generic;

namespace SchoolDemoApi.Data.Models
{
    public partial class School
    {
        public School()
        {
            BaselineEsses = new HashSet<BaselineEss>();
            BaselinePstOlds = new HashSet<BaselinePstOld>();
            BaselinePstRooms = new HashSet<BaselinePstRoom>();
            Essconstructions = new HashSet<Essconstruction>();
            Tool5Details = new HashSet<Tool5Detail>();
            Tool5s = new HashSet<Tool5>();
        }

        public short Sid { get; set; }
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

        public virtual BaselinePst? BaselinePst { get; set; }
        public virtual EssSiting? EssSiting { get; set; }
        public virtual ICollection<BaselineEss> BaselineEsses { get; set; }
        public virtual ICollection<BaselinePstOld> BaselinePstOlds { get; set; }
        public virtual ICollection<BaselinePstRoom> BaselinePstRooms { get; set; }
        public virtual ICollection<Essconstruction> Essconstructions { get; set; }
        public virtual ICollection<Tool5Detail> Tool5Details { get; set; }
        public virtual ICollection<Tool5> Tool5s { get; set; }
    }
}
