using System;
using System.Collections.Generic;

namespace SchoolDemoApi.Data.Entities
{
    public partial class Section
    {
        public Section()
        {
            AppUsers = new HashSet<AppUser>();
        }

        public int SectionId { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<AppUser> AppUsers { get; set; }
    }
}
