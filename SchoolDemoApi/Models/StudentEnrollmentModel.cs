namespace SchoolDemoApi.Models
{
    public class StudentEnrollmentModel
    {
        public short ProjectYear { get; set; }
        public DateTime Date { get; set; }
        public string? VisitorName { get; set; }
        public bool ReCollectData { get; set; }
        public bool Verified { get; set; }
        public int NewEnrollGirls { get; set; }
        public int NewEnrollBoys { get; set; }
        public int AttendRegGirls { get; set; }
        public int AttendRegBoys { get; set; }
        public int HeadCountBoys { get; set; }
        public short SchoolId { get; set; }
    }
}
