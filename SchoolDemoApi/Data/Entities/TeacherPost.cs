using System;
using System.Collections.Generic;

namespace SchoolDemoApi.Data.Entities
{
    public partial class TeacherPost
    {
        public TeacherPost()
        {
            BLteachers = new HashSet<BLteacher>();
        }

        public short PostId { get; set; }
        public string? PostName { get; set; }
        public string? PostFullName { get; set; }

        public virtual ICollection<BLteacher> BLteachers { get; set; }
    }
}
