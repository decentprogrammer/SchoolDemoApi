using Microsoft.AspNetCore.Identity;

namespace SchoolDemoApi.Data.Entities
{
    public class AppUser : IdentityUser
    {
        //public string Username { get; set; } = null!;
        public string? Password { get; set; }
        public int SectionId { get; set; }
        public bool IsActive { get; set; }

        public virtual Section Section { get; set; } = null!;
    }
}
