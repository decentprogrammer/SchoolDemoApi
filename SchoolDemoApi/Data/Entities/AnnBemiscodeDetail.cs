using System;
using System.Collections.Generic;

namespace SchoolDemoApi.Data.Entities
{
    public partial class AnnBemiscodeDetail
    {
        public int AnnualBemiscodeDetailId { get; set; }
        public int SchoolId { get; set; }
        public int Bemisid { get; set; }
        public string Bemiscode { get; set; } = null!;
    }
}
